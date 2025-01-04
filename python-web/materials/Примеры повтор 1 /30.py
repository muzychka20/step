#Сортировка списка словарей

people = [
    {"name": "John", "age": 25},
    {"name": "Alice", "age": 30},
    {"name": "Bob", "age": 20}
]

# Сортировка по возрасту
sorted_people = sorted(people, key=lambda person: person["age"])
print(sorted_people)