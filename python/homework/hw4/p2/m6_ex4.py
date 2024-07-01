def delete_elent_from_list(number, array):
  result = array.count(number)  
  for _ in range(result):
    array.remove(number)
  return result    
      
list = [2, 2, 3, 4, 2, 6, 2, 8, 9, 2]
print(delete_elent_from_list(2 , list))