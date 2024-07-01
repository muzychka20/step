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
    print("sum = ", sum(array))