def print_square(size, symbol, fill):
  if fill:
    for _ in range(size):
      print(symbol * 5)
    return  
  
  for i in range(size):
    for j in range(size):
      if i == 0 or i == size - 1 or j == 0 or j == size - 1:
        print(symbol, end='')
      else:
        print(' ', end='') 
    print()   
  
      
print_square(5, '@', False)