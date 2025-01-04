#4. Удаление элементов
#Для удаления элементов используются методы pop(), 
# del, а также можно удалить все элементы с помощью clear().

my_dict = {"name": "John", "age": 25, "city": "New York"}

# Удаление элемента и возврат его значения
age = my_dict.pop("age")
print(age)  # 25
print(my_dict)  # {'name': 'John', 'city': 'New York'}

# Удаление с помощью del
del my_dict["city"]
print(my_dict)  # {'name': 'John'}

# Очистка словаря
my_dict.clear()
print(my_dict)  # {}