try:
    name = input("Enter the name: ")
    age = int(input("Enter the age: "))
    if age > 130 or age < 0:
        raise ValueError("age is not valid")
    print(f"Привіт, {name}! Твій вік — {age}")
except ValueError:
    print("Enter correct age!")