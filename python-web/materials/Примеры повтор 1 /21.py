#3. Добавление и изменение элементов
#Можно легко добавлять новые пары "ключ: 
# значение" или изменять существующие значения по ключам.


my_dict = {"name": "John", "age": 25}

# Добавление нового ключа
my_dict["city"] = "New York"
print(my_dict)  # {'name': 'John', 'age': 25, 'city': 'New York'}

# Изменение значения
my_dict["age"] = 26
print(my_dict)  # {'name': 'John', 'age': 26, 'city': 'New York'}