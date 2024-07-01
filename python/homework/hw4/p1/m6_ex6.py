def get_amount_of_digits(number):
  amount = 0
  while number:
    amount += 1
    number //= 10
  return amount  

print(get_amount_of_digits(3456))