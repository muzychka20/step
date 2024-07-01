def get_min_of_list(array):
  return min(array)


def min_of_list(array):
  min = array[0]
  for i in array:
    if i < min:
      min = i
  return min
    

print(get_min_of_list([1, 2, 3, 4, 5]))
print(min_of_list([3, 2, 3, 1, 5]))