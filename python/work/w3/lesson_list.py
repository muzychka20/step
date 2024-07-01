# Приклади роботи зі списками в Python

# 2.1. Поняття класичного масиву
from array import array
# Створення масиву цілих чисел (тип 'i' означає цілі числа)
int_array = array('i', [1, 2, 3, 4, 5])
print(int_array)  # array('i', [1, 2, 3, 4, 5])

# 2.2. Поняття колекції об'єктів
# Списки можуть містити елементи різних типів
mixed_list = [1, "hello", 3.14, True]
print(mixed_list)  # [1, "hello", 3.14, True]

# 2.3. Послідовний тип даних list
# Створення списку за допомогою літералу
number_list = [1, 2, 3, 4, 5]
print(number_list)  # [1, 2, 3, 4, 5]

# 2.4. Створення списків
# Створення порожнього списку та списку з елементами
empty_list = []
fruits = ['apple', 'banana', 'cherry']
print(fruits)  # ['apple', 'banana', 'cherry']

# 2.5. Генератори списків
# Використання генераторів списків для створення списку квадратів чисел
squares = [x ** 2 for x in range(10)]
print(squares)  # [0, 1, 4, 9, 16, 25, 36, 49, 64, 81]

# 2.6. Робота зі списками
# Додавання елементів до списку
fruits.append('date')
print(fruits)  # ['apple', 'banana', 'cherry', 'date']

# Видалення елемента зі списку
fruits.remove('banana')
print(fruits)  # ['apple', 'cherry', 'date']

# 2.7. Методи списків
# Сортування списку
  # ['apple', 'cherry', 'date']

# Перевертання списку
fruits.reverse()
print(fruits)  # ['date', 'cherry', 'apple']

# Підрахунок кількості входжень елемента
print(fruits.count('apple'))  # 1

# Отримання індексу елемента
print(fruits.index('cherry'))  # 1

# 2.8. Оператор приналежності in
# Перевіряємо, чи є елемент 'apple' у списку fruits
if 'apple' in fruits:
    print("'apple' є у списку fruits.")
else:
    print("'apple' не є у списку fruits.")

# Перевіряємо, чи відсутній елемент 'mango' у списку fruits
if 'mango' not in fruits:
    print("'mango' не є у списку fruits.")
else:
    print("'mango' є у списку fruits.")

# 2.9. Особливості списків, посилання та клонування
# Створюємо копію списку fruits за допомогою методу .copy()
fruits_copy = fruits.copy()
# Модифікуємо копію та перевіряємо, що оригінал залишився без змін
fruits_copy.append('mango')
print("Оригінальний список fruits:", fruits)
print("Змінений копійований список fruits_copy:", fruits_copy)

# 2.10. Пошук елемента
# Знаходимо індекс елемента 'date' у списку fruits
# Якщо елемент не знайдено, виводимо повідомлення
try:
    index_of_date = fruits.index('date')
    print("Індекс елемента 'date':", index_of_date)
except ValueError:
    print("'date' не знайдено у списку fruits.")

# 2.11. Матриці
# Створюємо матрицю як список списків
matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
# Виводимо елементи з різних рядків та стовпців матриці
print("Елемент на позиції (0,0):", matrix[0][0])  # 1
print("Елемент на позиції (1,1):", matrix[1][1])  # 5
print("Елемент на позиції (2,2):", matrix[2][2])  # 9



