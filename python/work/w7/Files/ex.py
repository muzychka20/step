amount_200 = amount_404 = 0
try:
    with open('Logs1802.txt', 'r') as file, open("Erors.txt", 'w') as file_write:
        for line in file.readlines():
            line = line[:-1].split(', ')
            if line[2] == '200':
                amount_200 += 1
            elif line[2] == '404':
                amount_404 += 1
                file_write.write(', '.join(line) + '\n')
        print("amount_200:", amount_200)
        print("amount_404:", amount_404)
except FileNotFoundError:
    print("File not found!")