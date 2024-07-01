start = int(input("start = "))
end = int(input("end = "))

for i in range(start, end+1):
  if not i % 7:
    print(i)

