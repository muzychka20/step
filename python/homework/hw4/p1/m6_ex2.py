def print_even_numbers(low_limit, high_limit):
  for number in range(low_limit+1, high_limit):
    if not number % 2:
      print(number)
      

print_even_numbers(2, 20)