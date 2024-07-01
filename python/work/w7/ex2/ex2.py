file_write = open('./ex2_res.txt', 'w')
with open('./ex2.txt', 'r') as file:
    while True:
        line = file.readline()
        if not line:
            break
        file_write.write(line)
