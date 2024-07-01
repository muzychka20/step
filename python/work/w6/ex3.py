with open("./file.txt", 'w') as file:
    file.write('one\n')
    file.write('two\n')
    file.write('three\n')
    file.write('four\n')
    file.write('five\n')


with open("./file.txt", 'r') as file:
    array = []
    line = file.readline()[:-1]
    while line:
        array.append(line)
        line = file.readline()[:-1]
print(array)        