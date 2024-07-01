try:
    a = int(input("a = "))
    b = int(input("b = "))
    result = a / b
except ZeroDivisionError:
    print("b не може дорівнювати нулю")
except ValueError:
    print("a і b числа")
else:
    print(result)