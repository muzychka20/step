#Сортировка списка словарей

#Пример: Фильтрация словаря по значению
#Допустим, у нас есть словарь с именами и возрастами, 
# и мы хотим отфильтровать тех, чей возраст больше 25:
people = {
    "John": 25,
    "Alice": 30,
    "Bob": 20,
    "Eve": 28
}
# Фильтрация по значению (возраст > 25)
filtered_people = {name: age for name, age in people.items() if age > 25}
print(filtered_people)

#Пример: Фильтрация по ключу
#Фильтрация словаря по ключу работает аналогично. 
# Например, если нужно отфильтровать всех людей, чьи имена начинаются с буквы "A":
people = {
    "John": 25,
    "Alice": 30,
    "Bob": 20,
    "Eve": 28
}

# Фильтрация по ключу (имя начинается с 'A')
filtered_people = {name: age for name, age in people.items() if name.startswith("A")}
print(filtered_people)

#Пример: Фильтрация по нескольким условиям
#Можно фильтровать и по нескольким условиям, например, по ключу и по значению одновременно:
people = {
    "John": 25,
    "Alice": 30,
    "Bob": 20,
    "Eve": 28
}

# Фильтрация по нескольким условиям (имя начинается с 'A' и возраст больше 25)
filtered_people = {name: age for name, age in people.items() if name.startswith("A") and age > 25}
print(filtered_people)