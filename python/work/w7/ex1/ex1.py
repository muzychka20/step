with open('./ex1.txt', 'r') as file_read, open('./ex1_res.txt', 'w') as file_write:
    while True:
        line = file_read.readline()
        if not line:
            break
        if len(line) >= 7:
            file_write.write(line)
