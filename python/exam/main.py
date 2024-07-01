# Напишите функцию, которая умножает две матрицы. Матрицы могут быть произвольного размера, и программа должна обрабатывать случаи неправильных размеров.

m1 = [
    [1,2,2],
    [3,1,1], 
]

m2 = [
    [4, 2],
    [3, 1],
    [1, 5]
]

res = [[0 for _ in range(len(m2[0]))] for _ in range(len(m1))]

try:
    if len(m1[0]) != len(m2):
        raise Exception("Can not multiply!")
    
    for i in range(len(m1)):
        for j in range(len(m2[0])):
            for k in range(len(m1[0])):
                res[i][j] += m1[i][k] * m2[k][j]
   
    for row in res:
        for el in row:
            print(el, end=' ')
        print()
        
except Exception as e:
    print(f"{e}")
