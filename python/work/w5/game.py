import random


max_length = 4


def get_number():
    result = []
    result.append(random.randint(1, 9))
    while len(result) != max_length:
        n = random.randint(0, 9)
        if n not in result:
            result.append(n)               
    result_number = 0
    for el in result:
        result_number *= 10 
        result_number += el
    return result_number


def calculate_bulls(user_number, number):
    amount = 0
    while user_number:
        if user_number % 10 == number % 10:
            amount += 1
        user_number //= 10
        number //= 10
    return amount    


def calculate_cows(user_number, number):
    amount = 0
    user_number_list = []
    number_list = []
    for _ in range(max_length):
        user_number_list.append(user_number % 10)
        number_list.append(number % 10)
        user_number //= 10
        number //= 10
    for el in user_number_list:
        if el in number_list:
            amount += 1
    return amount                


number = get_number()
print(number)

user_number = int(input("Enter a number: "))

bulls = calculate_bulls(user_number, number)
print("Быки:", bulls)

cows = calculate_cows(user_number, number)
print("Коровы:", cows)

