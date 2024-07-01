array = ['apple', 'banana', 'orange', 'kiwi', 'mango', 'pear', 'grape', 'strawberry', 'blueberry', 'pineapple']
array_with_long_words = []
if len(array) == 10:
    with open('file.txt', 'w') as file: 
        for word in array:            
            file.write(f"{word}\n")
    with open('file.txt', 'r') as file:
        while True:
            line = file.readline()[:-1]
            if not line:
                break
            if len(line) > 5:
                array_with_long_words.append(line)
print(array_with_long_words)                
            