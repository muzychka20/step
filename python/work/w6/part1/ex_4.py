#1
def string_to_int1(string):
    return int(string)

try:
    string = input("Enter number: ")
    number = string_to_int1(string)
    print(number)
    print(type(number))
except ValueError as e:    
    print(f"Enter number! Error: {e}")


#2
def string_to_int(string):
    try:
        return int(string)
    except ValueError as e:    
        print(f"Enter number! Error: {e}")


string = input("Enter number: ")
number = string_to_int(string)
print(number)
print(type(number))