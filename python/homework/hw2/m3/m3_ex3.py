meters = float(input("meters = "))

print("Choose operation: 1 - mile; 2 - inch; 3 - yard")
operation = int(input("Enter the number of operation: "))

if operation == 1:
  mile = meters * 0.00062137
  print(mile)
elif operation == 2:
  inch = meters * 39.37
  print(inch)  
elif operation == 3:
  yard = meters * 1.0936
  print(yard)
else:
  print("Invalid operation number!")
