#7. Словари с вложенными структурами
#Словари могут содержать другие структуры данных, такие как списки, множества и даже другие словари.

# Словарь с вложенным списком
my_dict = {
    "name": "John",
    "age": 25,
    "hobbies": ["reading", "traveling", "music"]
}

# Словарь с вложенным словарем
nested_dict = {
    "person": {"name": "Alice", "age": 30},
    "address": {"city": "Los Angeles", "zipcode": "90001"}
}
print(nested_dict["person"]["name"])  # Alice