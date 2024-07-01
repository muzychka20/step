
import math


def my_sqrt(n):
    try:
        return math.sqrt(n)
    except ValueError as e:
        print(f"Error: {e}, number should be positive")


number = int(input("Enter number: "))

print(my_sqrt(number))