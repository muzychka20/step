def pow_list(power, array):
  result_array = []
  for i in array:
    result_array.append(i ** power)
  return result_array

print(pow_list(2, [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]))