num1 = float(input("num1 = "))
num2 = float(input("num2 = "))
num3 = float(input("num3 = "))

print("Choose operation: 1 - add; 2 - multiply")
operation = int(input("Enter the number of operation: "))

if operation == 1:
  print(num1 + num2 + num3)
elif operation == 2:
  print(num1 * num2 * num3)
else:
  print("Invalid operation number!")
