from numpy import *
from numpy import linalg as la
import sys

if __name__ == "__main__":
    # row = np.random.
    set_printoptions(threshold=sys.maxsize)
    A = random.randint(0, 10, [50, 200])
    print(A)
    print("\n")
    U, S, V = la.svd(A)

    # print(U)
    # print("\n")
    # print(S)
    # print("\n")
    # print(V)
