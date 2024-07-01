# Завдання 1: Перевірка на парність/непарність

number = int(input("Введіть число: "))
if number % 2 == 0:
    print(f"{number} - Even number")
else:
    print(f"{number} - Odd number")


#--------------------------------------------
# Завдання 2: Перевірка на кратність 7

number = int(input("Введіть число: "))
if number % 7 == 0:
    print(f"{number} - Number is a multiple of 7")
else:
    print(f"{number} - Number is not a multiple of 7")


#--------------------------------------------
# Завдання 3: Знаходження максимуму із двох чисел

number1 = int(input("Введіть перше число: "))
number2 = int(input("Введіть друге число: "))
max_number = max(number1, number2)
print("Максимум:", max_number)

#--------------------------------------------
# Завдання 4: Знаходження мінімуму із двох чисел

number1 = int(input("Введіть перше число: "))
number2 = int(input("Введіть друге число: "))
min_number = min(number1, number2)
print("Мінімум:", min_number)

#--------------------------------------------
# Завдання 5: Математичні операції з двома числами

number1 = int(input("Введіть перше число: "))
number2 = int(input("Введіть друге число: "))

print("Виберіть операцію: 1 - Сума, 2 - Різниця, 3 - Середньоарифметичне, 4 - Добуток")
operation = input("Введіть номер операції: ")

if operation == '1':
    print("Сума:", number1 + number2)
elif operation == '2':
    print("Різниця:", number1 - number2)
elif operation == '3':
    print("Середньоарифметичне:", (number1 + number2) / 2)
elif operation == '4':
    print("Добуток:", number1 * number2)
else:
    print("Неправильний вибір операції")

    #--------------------------------------------