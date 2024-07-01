# read file
array = []
with open("C:\\lessons\\python\\lesson5\\files\\file.txt", 'r') as file:
    line = file.readline()[:-1]
    while line:
        array.append(line)
        line = file.readline()[:-1]

print(array)


# write in file (rewriting file)
with open("C:\\lessons\\python\\lesson5\\files\\file.txt", 'w') as file:
    file.write("Hi!\n")
    file.write("world\n")


# write in file (adding text)
with open("C:\\lessons\\python\\lesson5\\files\\file.txt", 'a') as file:
    file.write("Hello!\n")
    file.write("world\n")