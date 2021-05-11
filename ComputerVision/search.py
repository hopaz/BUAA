import argparse as ap
import cv2
from sklearn.externals import joblib
from scipy.cluster.vq import *
from sklearn import preprocessing
from pylab import *
from PIL import Image

# 获取图片路径
parser = ap.ArgumentParser()
parser.add_argument("-i", "--image", help="Path to query image", required=True)
args = vars(parser.parse_args())
image_path = args["image"]

# 加在分类器，图片路径，idf， 词汇数量，词典
im_features, image_paths, idf, numWords, voc = joblib.load("data.pkl")

# 创建特征提取对象
fea_det = cv2.xfeatures2d.SIFT_create()

# 存储描述子
des_list = []

# sift特征提取
im = cv2.imread(image_path)
kps, descs = fea_det.detectAndCompute(im, None)
des_list.append((image_path, descs))
descrs = des_list[0][1]
test_features = np.zeros((1, numWords), "float32")
words, distance = vq(descrs,voc)
for w in words:
    test_features[0][w] += 1

# 计算Tf-Idf向量和L2 normalization
test_features = test_features*idf
test_features = preprocessing.normalize(test_features, norm='l2')

# 计算距离
score = np.dot(test_features, im_features.T)
rank_ID = np.argsort(-score)

# 结果可视化
figure()
gray()
subplot(5,4,1)
imshow(im[:,:,::-1])
axis('off')
for i, ID in enumerate(rank_ID[0][0:16]):
    img = Image.open(image_paths[ID])
    gray()
    subplot(5,4,i+5)
    imshow(img)
    axis('off')

show()