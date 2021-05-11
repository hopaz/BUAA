import os
from PIL import Image
from numpy import *
from pylab import *
from matplotlib.pyplot import plot, imshow, axis
from matplotlib.pyplot import figure, gray, show
from numpy import array
import sift
from PIL import Image

def process_image(imagename, resultname, params="--edge-thresh 10 --peak-thresh 5"):
    """处理一幅图像，然后将结果保存在文件中"""
    if imagename[-3:0] != 'pgm':
        # 创建一个pgm文件
        im = Image.open(imagename).convert('L')
        im.save('tmp.pgm')
        imagename = 'tmp.pgm'

    cmmd = str("sift" + imagename + " --output=" + resultname + " " + params)
    os.system(cmmd)
    print("processed", imagename, "to", resultname)

def read_features_from_file(filename):
    """ 读取特征属性值，然后将其以矩阵的形式返回"""
    f = loadtxt(filename)
    return f[:, :4], f[:, 4:] # 特征位置，描述子


def write_feature_to_file(filename, locs, desc):
    """ 将特征位置和描述子保存到文件中"""
    savetxt(filename, hstack((locs, desc)))


def plot_features(im, locs, circle=False):
    """ 显示带有特征的图像，输入:im(数组图像）， locs(每个特征的行，列，尺度，和方向角度）"""
    def draw_circle(c, r):
        t = arange(0, 1.01, 0.01)*2*pi
        x = r*cos(t) + c[0]
        y = r*sin(t) + c[1]
        plot(x, y, 'b', linewidth=2)

    imshow(im)
    if circle:
        for p in locs:
            draw_circle(p[:2], p[2])
    else:
        plot(locs[:, 0], locs[:, 1], 'ob')
    axis('off')

def match(desc1, desc2):
    """
    对于第一幅图像中的每个描述子，选取其在第二幅图像中的匹配
    输入：desc1（第一幅图像中的描述子）， desc2（第二幅图像中的描述子）
    """
    desc1 = array([d/linalg.norm(d) for d in desc1])
    desc2 = array([d/linalg.norm(d) for d in desc2])

    dist_ratio = 0.6
    desc1_size = desc1.shape

    matchscores = zeros((desc1_size[0], 1), 'int')
    desc2t = desc2.T  # 预先计算矩阵转置
    for i in range(desc1_size[0]):
        dotprods = dot(desc1[i, :], desc2t) # 向量点乘
        dotprods = 0.9999 * dotprods
        # 反余弦和反排序，返回第二幅图像中特征的索引
        indx = argsort(arccos(dotprods))

        # 检查最近邻的角度是否小于dist_ratio乘以第二近邻的角度
        if arccos(dotprods)[indx[0]] < dist_ratio * arccos(dotprods)[indx[1]]:
            matchscores[i] = int (indx[0])
    return matchscores

def match_twosides(desc1, desc2):
    """ 双向对称版本的match()"""
    matches_12 = match(desc1, desc2)
    matches_21 = match(desc2, desc1)

    ndx_12 = matches_12.nonzero()[0]

    # 去除不对称的匹配
    for n in ndx_12:
        if matches_21[int(matches_12[n])] != n:
            matches_12[n] = 0
    return matches_12

def appendimages():
    pass

def plot_matches():
    pass


if __name__ == '__main__':
    imname = 'data/ant_0001.jpg'
    im1 = array(Image.open(imname).convert('L'))
    sift.process_image(imname, 'ant_0001.sift')
    l1, d1 = sift.read_features_from_file('ant_0001.sift')

    figure()
    gray()
    sift.plot_features(im1, l1, circle=True)
    show()

