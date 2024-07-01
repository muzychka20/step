num1 = float(input("num1 = "))
num2 = float(input("num2 = "))
num3 = float(input("num3 = "))

print("Choose operation: 1 - max; 2 - min; 3 - average")
operation = int(input("Enter the number of operation: "))

if operation == 1:
  max_value = num1 if (num1 > num2 and num1 > num3) else (num2 if num2 > num1 and num2 > num3 else num3)
  print(max_value)
elif operation == 2:
  min_value = num1 if (num1 < num2 and num1 < num3) else (num2 if num2 < num1 and num2 < num3 else num3)
  print(min_value)
elif operation == 3:
  average_value = (num1 + num2 + num3) / 3
  print(average_value)
else:
  print("Invalid operation number!")
