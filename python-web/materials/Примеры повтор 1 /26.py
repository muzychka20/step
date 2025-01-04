#8. Основные методы словаря
#keys(): Возвращает список всех ключей в словаре.
#values(): Возвращает список всех значений в словаре.
#items(): Возвращает пары "ключ: значение".
#update(): Обновляет словарь, добавляя новые пары или изменяя существующие значения.


my_dict = {"name": "John", "age": 25}

# Получение всех ключей
print(my_dict.keys())  # dict_keys(['name', 'age'])

# Получение всех значений
print(my_dict.values())  # dict_values(['John', 25])

# Получение всех пар "ключ: значение"
print(my_dict.items())  # dict_items([('name', 'John'), ('age', 25)])

# Обновление словаря
my_dict.update({"city": "New York", "age": 26})
print(my_dict)  # {'name': 'John', 'age': 26, 'city': 'New York'}