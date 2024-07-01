def is_prime_number(number):
  amount_of_divisors = 0
  for i in range(1, number+1):
    if not number % i:
      amount_of_divisors += 1
  return amount_of_divisors == 2


def get_amount_of_prime_numbers(array):
  result = 0
  for i in array:
    if is_prime_number(i):
      result += 1
  return result    


print(get_amount_of_prime_numbers([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]))