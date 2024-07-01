array = []
with open('./ex3.txt', 'r') as file_read, open('./ex3_res.txt', 'w') as file_write:
    while True:
        line = file_read.readline()
        if not line:
            break
        array.append(line)
    array.reverse()    
    for i in array:
    # for i in range(len(array)-1, -1, -1):
        file_write.write(i)
