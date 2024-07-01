with open('ex4.txt', 'r') as file:
    max_line = line = file.readline()[:-1]    
    max = len(line)
    while line:
        line = file.readline()[:-1]
        if len(line) > max:
            max = len(line)
            max_line = line

print(max_line)
print("Length: ", max)
        