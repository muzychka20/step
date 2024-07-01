# 1
def get_sum_1(array):    
    return sum(array)


try:
    array = list(map(int, input("Enter positive numbers: ").split(' ')))
    for i in array:
        if i < 0:
            raise Exception("There is negative elements!")
except ValueError as e:
    print(f"Enter numbers! {e}")
except Exception as e:
    print(e)
else:
    print("sum = ", get_sum_1(array))    


# 2    
def get_sum_2(array): 
    for i in array:
        if i < 0:
            raise Exception("There is negative elements!")   
    return sum(array)


try:
    array = list(map(int, input("Enter positive numbers: ").split(' ')))
    result = get_sum_2(array)
except ValueError as e:
    print(f"Enter numbers! {e}")
except Exception as e:
    print(e)
else:
    print("sum = ", result)