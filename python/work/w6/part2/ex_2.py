
import math

#1
def my_sqrt(n):
    return math.sqrt(n)


try:
    number = int(input("Enter number: "))
    print(my_sqrt(number))
except ValueError as e:
    print(f"Error: {e}, number should be positive")


#2
def my_sqrt(n):
    try:
        return math.sqrt(n)
    except ValueError as e:
        print(f"Error: {e}, number should be positive")


number = int(input("Enter number: "))
print(my_sqrt(number))


