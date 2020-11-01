from numpy import *
from numpy import linalg as la
import sys

if __name__ == "__main__":
    set_printoptions(threshold=sys.maxsize)
    # A是50X200的矩阵，50行代表用户数目，200列代表商家数目
    A = random.randint(0, 10, [50, 200])
    U, S, V = la.svd(A)
    # U代表50个用户与50个商家合并类的关系？
    print(U.shape, U)
    # S表示50个合并类之间的关系？
    print(S.shape, S)
    # V表示？？
    print(V.shape, V)


