num = int(input("num = "))
arr = list()
result = 0
temp = num

while num:
    arr.append(num % 10)
    num //= 10 

t = arr[2]
arr[2] = arr[3]
arr[3] = t

for el in arr:
    result *= 10
    result += el
    
print(result)    

result = 0

while temp: 

    if (10 <= result and result < 100): 
        result *= 100
        result += temp % 100
        temp //= 100
    else:
        result *= 10
        result += temp % 10
        temp //= 10


print(result)