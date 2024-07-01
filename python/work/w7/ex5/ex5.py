user_input = input("Enter start symbol: ")
amount = 0
with open('ex5.txt', 'r') as file_read:
    while True:
        line = file_read.readline()[:-1]
        if not line:
            break        
        if line[0] == user_input:
            amount += 1
print(amount)            