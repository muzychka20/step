with open('ex3.txt', 'r') as file:
    lines = file.readlines()
 
lines.pop() 
    
with open('ex3_result.txt', 'w') as file:
    file.writelines(lines)