
def print_borders(size):
    for i in range(size-1):
        print("|", end="")
        for j in range(size):
            print(" ", end="")
        print("|")    

def print_first_row(array):
    print("|", end="")
    for el in array:
        if el:
            print("-", end="")
        else:
            print(" ", end="") 
    print("|")

def print_bottom(size):
    print(" ", end="")
    for i in range(size):
        print("-", end="")
    print(" ")    


size = 5
arr = [0,0,1,0,0]

while True:
    print_borders(size)  
    print_first_row(arr)
    print_bottom(size)
    choose = int(input("move: "))
    if choose == 3:
        break
    for i in range(size):
        if arr[i]:
            if choose == 1 and i > 0:
                arr[i-1] = 1
                arr[i] = 0
            elif choose == 2 and i < size-1:
                arr[i+1] = 1
                arr[i] = 0
            break


   
