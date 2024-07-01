user_word = input('Enter the word for searching: ')
amount = 0

with open('ex5.txt', 'r') as file:
    while True:
        line = file.readline()[:-1]
        if not line:
            break
        for word in line.split():
            if user_word == word:
                amount += 1

print("Amount:", amount)
