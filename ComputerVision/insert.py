import argparse as ap
import cv2
import numpy as np
import os
import joblib
from scipy.cluster.vq import *
from sklearn import preprocessing


# 获取数据集路径
parser = ap.ArgumentParser()
parser.add_argument("-d", "--data", help="Path to Data Set", required=True)
args = vars(parser.parse_args())

# 获取图片路径，并保存在列表中
data_path = args["data"]
data_names = os.listdir(data_path)
image_paths = []
for data_name in data_names:
    image_path = os.path.join(data_path, data_name)
    image_paths += [image_path]

# 词汇数量
numWords = 1000

# 保存描述子的列表
des_list = []

# sift特征提取
fea_det = cv2.xfeatures2d.SIFT_create()
for i, image_path in enumerate(image_paths):
    im = cv2.imread(image_path)
    print("Extract SIFT of %s image, %d of %d images" %(data_names[i], i, len(image_paths)))
    kps, descs = fea_det.detectAndCompute(im, None)
    des_list.append((image_path, descs))

# 保存描述子
descriptors = des_list[0][1]
for image_path, descriptor in des_list[1:]:
    descriptors = np.vstack((descriptors, descriptor))

# K-means聚类
print("Start k-means: %d words, %d key points" %(numWords, descriptors.shape[0]))
voc, variance = kmeans(descriptors, numWords, 1)

# 计算特征直方图
im_features = np.zeros((len(image_paths), numWords), "float32")
for i in range(len(image_paths)):
    words, distance = vq(des_list[i][1], voc)
    for w in words:
        im_features[i][w] += 1

# 计算 Tf-Idf 向量
nbr_occurences = np.sum((im_features > 0) * 1, axis = 0)
idf = np.array(np.log((1.0*len(image_paths)+1) / (1.0*nbr_occurences + 1)), 'float32')

# 计算 L2 normalization
im_features = im_features*idf
im_features = preprocessing.normalize(im_features, norm='l2')

joblib.dump((im_features, image_paths, idf, numWords, voc), "data.pkl", compress=3)
