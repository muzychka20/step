def get_amount_of_digits(number):
  amount = 0
  while number:
    amount += 1
    number //= 10
  return amount  


def is_palindrome(number):
  amount_of_digits = get_amount_of_digits(number)
  
  if amount_of_digits % 2:
    return False
  
  half_digits = 10 ** (amount_of_digits // 2)
  second_part = number % half_digits
  first_part = number // half_digits
  
  reversed_part = 0
  while second_part:
    reversed_part *= 10
    reversed_part += second_part % 10
    second_part //= 10
  
  return first_part == reversed_part  
    
  
print(is_palindrome(123321))  