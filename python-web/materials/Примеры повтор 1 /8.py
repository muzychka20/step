#8. Основные операции с кортежами
#Конкатенация кортежей: Можно объединить два или более кортежей.
#Повторение кортежей: Используется оператор *.
#Проверка наличия элемента: Используется оператор in.

tuple1 = (1, 2, 3)
tuple2 = (4, 5)

# Конкатенация
new_tuple = tuple1 + tuple2
print(new_tuple)  # (1, 2, 3, 4, 5)

# Повторение
repeated_tuple = tuple1 * 2
print(repeated_tuple)  # (1, 2, 3, 1, 2, 3)

# Проверка наличия элемента
print(2 in tuple1)  # True