#5. Итерация по словарю
#Можно итерироваться как по ключам, так и по значениям словаря.

my_dict = {"name": "John", "age": 25, "city": "New York"}

# Итерация по ключам
for key in my_dict:
    print(key)

# Итерация по значениям
for value in my_dict.values():
    print(value)

# Итерация по ключам и значениям
for key, value in my_dict.items():
    print(f"{key}: {value}")