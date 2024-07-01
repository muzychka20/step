def multiply_elements_of_list(array):
  result = 1
  for i in array:
    result *= i
  return result


print(multiply_elements_of_list([1, 2, 3, 4, 5]))