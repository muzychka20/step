start = int(input("start = "))
end = int(input("end = "))

print("1) ", end="")
for i in range(start, end+1):
  print(i, end=" ")
  
print("\n2) ", end="")
for i in range(end, start-1, -1):
  print(i, end=" ")
  
print("\n3) ", end="")
for i in range(start, end+1):
  if not i % 7:
    print(i, end=" ")
    
print("\n4) ", end="")
amount = 0
for i in range(start, end+1):
  if not i % 5:
    amount = amount + 1
print(amount)