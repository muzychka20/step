number_line = index = 0
array = []
with open('ex4.txt', 'r') as file_read, open('ex4_res.txt', 'w') as file_write:
    while True:
        index += 1
        line = file_read.readline()[:-1]
        if not line:
            break
        array.append(line)
        if not line.count(','):
            number_line = index
    for i in range(len(array)):
        if i == number_line:
            file_write.write("************\n")
        file_write.write(array[i] + '\n')