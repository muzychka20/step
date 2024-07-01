start = int(input("start = "))
end = int(input("end = "))

for i in range(start, end+1):
  if not i % 3 and not i % 5:
    print("Fizz Buzz")
  elif not i % 3:
    print("Fizz")
  elif not i % 5:
    print("Buzz")
  else:
    print(i)  