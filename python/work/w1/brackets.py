def symbols(x, y):
    if x == '(' and y == ')':
        return 1
    elif x == '{' and y == '}':
        return 1
    elif x == '[' and y == ']':
       return 1 
    return 0

string = "(gdfhb)(}})({{)"

array = list()

result = True

for i in range(0, len(string)):
    if string[i] == '(' or string[i] == '{' or string[i] == '[':
        array.append(string[i])
        continue
    if string[i] == ')' or string[i] == '}' or string[i] == ']':        
        if not symbols(array[len(array)-1], string[i]):
            result = False
            break
    
print(result)
