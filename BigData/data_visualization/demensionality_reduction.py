# -*- coding: UTF-8 -*-
import numpy as np
import pandas as pd
from sklearn.manifold import TSNE
from sklearn.impute import SimpleImputer
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import Axes3D

def get_data(path, label_name):
    df = pd.read_csv(path)
    # pandas axis=1 为列
    # data = df.drop("class", axis=1)
    data = df
    label = df[label_name].to_numpy()
    return data, label


def pretreatment(data):
    data_copy = data.copy()
    imputer = SimpleImputer(missing_values=np.NAN, strategy="mean")
    imputer = imputer.fit(data_copy)
    result = imputer.transform(data_copy)
    return result


def plot_emmbedding(data):
    # numpy axis=0 为列
    x_min, x_max = np.min(data, 0), np.max(data, 0)
    data = (data - x_min) / (x_max - x_min)
    return data


def tsne(data, n_components):
    if n_components == 2:
        # TSNE函数init参数传pca，数据显示出来全部聚在一团；不传，就显示为2个簇
        tsne = TSNE(n_components)
        tsne_data = tsne.fit_transform(data)
        aim_data = plot_emmbedding(tsne_data)
        plt.figure()
        plt.subplot(111)
        plt.scatter(aim_data[:, 0], aim_data[:, 1], c=label)
    elif n_components == 3:
        tsne = TSNE(n_components)
        tsne_data = tsne.fit_transform(data)
        aim_data = plot_emmbedding(tsne_data)
        fig = plt.figure()
        plt.subplot(111)
        ax = Axes3D(fig)
        ax.view_init(0, 45) # 第一个参数是垂直方向，第二个参数是水平方向
        # c使用label可以将不同类以颜色区分开
        ax.scatter(aim_data[:, 0], aim_data[:, 1], aim_data[:, 2], c=label)
    else:
        print("The value of n_components can only be 2 or 3")
    plt.show()

if __name__ == "__main__":
    # 1-64列为公司财务数据；65列名为class，为1/0代表在预测期破产/未破产的公司
    data, label = get_data("./csv_result-1year.csv", "class")
    data_tmp = pretreatment(data)
    tsne(data_tmp, 3)
    tsne(data_tmp, 2)





