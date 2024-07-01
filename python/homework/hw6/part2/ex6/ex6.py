user_new_word = input("Enter new word: ")
user_old_word = input("Enter old word: ")

text = []


with open('ex6.txt', 'r') as file:
    while True:
        line = file.readline()[:-1]
        if not line:
            break
        line = line.split() 
        for i in range(len(line)):
            if line[i] == user_old_word:
                line[i] = user_new_word
        text.append(' '.join(line))


with open('ex6_result.txt', 'w') as file:
    for line in text:
        file.write(f"{line}\n")