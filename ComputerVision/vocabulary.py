from scipy.cluster.vq import *
# import vlfeat as sift
import sift
import pickle
from PIL import Image
from numpy import *
from pylab import *

class Vocabulary(object):
    def __init__(self, name):
        self.name = name
        self.voc = []
        self.idf = []
        self.trainingdata = []
        self.nbr_words = 0

    def train(self, featurefiles, k=100, subsampling=10):
        """用含有k个单词的K-means列出在featurefiles中的特征文件训练出一个词汇。对训练数据下采样可以加快训练速度"""
        nbr_images = len(featurefiles)
        descr = []
        descr.append(sift.read_feature_from_file(featurefiles[0][1]))
        descriptors = descr[0] #将所有特征并在一起，一边后面进行k-means聚类
        for i in range(1, nbr_images):
            descr.append(sift.read_feature_from_file(featurefiles[0][1]))
            descriptors = vstack((descriptors, descr[i]))

        # K-means:最后一个参数决定运行次数
        self.voc, distortion = kmeans(descriptors[::subsampling, :], k, 1)
        self.nbr_words = self.voc.shape[0]

        # 遍历所有的训练图像，并投影到词汇上
        imwords = zeros((nbr_images, self.nbr_words))

        for i in range(nbr_images):
            imwords[i] = self.project(descr[i])

        nbr_occurances = sum((imwords > 0) * 1, axis = 0)

        self.idf = log((1.0*nbr_images) / (1.0 * nbr_occurances + 1))
        self.trainingdata = featurefiles

    def project(self, descriptors):
        """ 将描述子投影到词汇上，以创建单词直方图"""
        # 图像单词直方图
        imhist = zeros((self.nbr_words))
        words, distance = vq(descriptors, self.voc)
        for w in words:
            imhist[w] += 1

        return imhist


if __name__ == "__main__":
    nbr_images = len(imlist)
    featlist = [imlist[i][:-3] + 'sift' for i in range(nbr_images)]

    voc = vocabulary.Vocabulary('ukbenchtest')
    voc.train(featlist, 1000, 10)

    # 保存词汇
    with open("vocabulary.pkl", 'wb') as f:
        pickle.dumps(voc, f)

    print('vocabulary is:', voc.name, voc.nbr_words)