file1 = open('ex1_1.txt', 'r')
file2 = open('ex1_2.txt', 'r')


while True:
    line1 = file1.readline()[:-1]
    line2 = file2.readline()[:-1]
    if not line1 or not line2:
        break
    if line1 != line2:
        print(f"{line1} - {line2}")