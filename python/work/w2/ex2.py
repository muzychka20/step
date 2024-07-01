num = int(input("num = "))
sum1 = sum2 = 0

for i in range(3):
    sum2 += num % 10
    num = num // 10

for i in range(3):
    sum1 += num % 10
    num = num // 10

print(sum1)
print(sum2)

if sum1 == sum2:
    print("happy")
else:
    print("sad")
