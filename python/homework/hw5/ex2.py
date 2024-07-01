import random
import os
from colorama import Fore

length_of_number = 4


def get_number():
    array = []
    digit = random.randint(1, 9)
    array.append(digit)
    while len(array) < length_of_number:
        digit = random.randint(0, 9)
        if digit not in array:
            array.append(digit)
    string_number = [str(i) for i in array]
    return int(''.join(string_number))


def get_array_from_number(number, array):
    if not number:
        return array
    array.append(number % 10)
    return get_array_from_number(number // 10, array)


def clear_screen():
    os.system('cls' if os.name == 'nt' else 'clear')


def invalid_input():
    print(Fore.RED + "Invalid input!" + Fore.RESET)


def get_bulls_and_cows(number, user_input):
    bulls = cows = 0
    array_of_number = get_array_from_number(number, [])
    array_of_user_input = get_array_from_number(user_input, [])
    if len(array_of_number) == len(array_of_user_input):
        for i in range(length_of_number):
            if array_of_user_input[i] == array_of_number[i]:
                cows += 1
            if array_of_user_input[i] in array_of_number:
                bulls += 1
    else:
        invalid_input()
    return bulls, cows


def print_line():
    print("------------------------------------------")


def print_rules():
    print(Fore.CYAN, end='')
    print_line()
    print("| Cows - correct code, correct position. |")
    print("| Bulls - correct code, wrong position.  |")
    print_line()
    print(Fore.RESET, end='')


def print_info(amount_bulls, amount_cows):
    print(Fore.GREEN, end='')
    print("--------------")
    print("| Bulls\tCows |")
    print("|   {} \t  {}  |".format(amount_bulls, amount_cows))
    print("--------------")
    print(Fore.RESET, end='')


def play_game():
    clear_screen()
    print_rules()
    number_for_guess = get_number()
    attempts = 0
    while True:
        try:
            user_number = int(input("Enter number: "))
            amount_bulls, amount_cows = get_bulls_and_cows(number_for_guess, user_number)
            print_info(amount_bulls, amount_cows)
            attempts += 1
            if amount_cows == length_of_number:
                break
        except:
            invalid_input()
    print(Fore.RED + f"You win! Attempts: {attempts}" + Fore.RESET)


play_game()
