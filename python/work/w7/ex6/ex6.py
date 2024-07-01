with open('./ex6.txt', 'r') as file_read, open('./ex6_res.txt', 'w') as file_write:
    while True:
        line = file_read.readline()[:-1]
        if not line:
            break        
        line = line.replace('*', '&')
        file_write.write(line + '\n')