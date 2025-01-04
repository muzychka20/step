#2. Доступ к элементам словаря
#К элементам словаря можно обращаться по ключам. 
# Если ключа нет в словаре, возникнет ошибка KeyError. 
# Для безопасного доступа можно использовать метод get().

my_dict = {"name": "John", "age": 25, "city": "New York"}

# Доступ к элементу
print(my_dict["name"])  # John

# Безопасный доступ
print(my_dict.get("name"))  # John
print(my_dict.get("job", "Not found"))  # Not found