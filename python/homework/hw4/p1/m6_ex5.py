def multiply(low_limit, high_limit):
  result_of_multiply = 1
  if low_limit > high_limit:
    low_limit, high_limit = high_limit, low_limit
  for i in range(low_limit, high_limit + 1):
    result_of_multiply *= i
  return result_of_multiply
    
    
print(multiply(5, 1))