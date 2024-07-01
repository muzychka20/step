try:
    string = int(input("Enter number: "))
except ValueError as e:    
    print(f"Enter number! Error: {e}")
