# 1
def greetings_1(name, age):
    return f"Привіт, {name}! Твій вік — {age}"


try:
    name = input("Enter the name: ")
    age = int(input("Enter the age: "))
    if age > 130 or age < 0:
        raise ValueError("age is not valid")
    result = greetings_1(name, age)        
    print(result)
except ValueError as e:
    print(f"Enter correct age! {e}")    


# 2
def greetings_2(name, age):
    try:
        if int(age) > 130 or int(age) < 0:
            raise ValueError("age is not valid")
        return f"Привіт, {name}! Твій вік — {age}"
    except ValueError as e: 
        return f"Enter correct age! {e}"


name = input("Enter the name: ")
age = input("Enter the age: ")
result = greetings_2(name, age)
print(result)