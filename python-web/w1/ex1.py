# 1 --------------------------------------------------------------------
print("1 --------------------------------------------------------------")
import random
my_tuple = tuple(random.randint(1, 100) for _ in range(5))
print(my_tuple)
print('[1]:', my_tuple[1], '[3]:', my_tuple[3])


# 2 --------------------------------------------------------------------
print("2 --------------------------------------------------------------")
names = ("Alice", "Bob", "Sam")
ages = tuple(random.randint(1, 100) for _ in range(5))
res_names_ages = tuple(values for values in zip(names, ages))
print(res_names_ages)


# 3 --------------------------------------------------------------------
print("3 --------------------------------------------------------------")
my_array = ["apple", "banana", "cherry"]
print(type(my_array))
res_tuple = tuple(my_array)
print(type(res_tuple))
print(f"min: {min(res_tuple)}, max: {max(res_tuple)}")


# 4 --------------------------------------------------------------------
print("4 --------------------------------------------------------------")
import random
my_tuple_with_numbers = tuple(random.randint(1, 100) for _ in range(5))
print(f"{my_tuple_with_numbers}\nmin: {min(my_tuple_with_numbers)}, max: {max(my_tuple_with_numbers)}")


# 5 --------------------------------------------------------------------
print("5 --------------------------------------------------------------")
set1 = {1, 2, 3, 4, 5}
set2 = {4, 5, 6, 7, 8}
print("set1", set1)
print("set2", set2)
print("&:", set1 & set2)
print("|:", set1 | set2)
print("1-2:", set1 - set2)
print("2-1:", set2 - set1)
print("^:", set2 ^ set1)


# 6 --------------------------------------------------------------------
print("6 --------------------------------------------------------------")
chars = input("Enter symbols: ")
chars_set = set(chars)
print(chars, chars_set)
print(len(chars_set) == len(chars))


# 7 --------------------------------------------------------------------
print("7 --------------------------------------------------------------")
ar = [1, 3, 3, 5, 7, 9, 1, 5, 7]
print(ar, set(ar))


# 8 --------------------------------------------------------------------
print("8 --------------------------------------------------------------")
set1 = {1, 2, 3, 4, 5}
set2 = {4, 5, 6, 7, 8}
print(set1, set2)
print(set1 - set2)


# 9 --------------------------------------------------------------------
print("9 --------------------------------------------------------------")
products = {
    "banana": 20,
    "apple": 25
}
enter_product = input("Enter Product:")
print(products.get(enter_product, "Not Found"))


# 10 --------------------------------------------------------------------
print("10 --------------------------------------------------------------")
enter_string = input("10) Enter string: ")
my_dict = {el: enter_string.count(el) for el in set(enter_string)}
print(my_dict)


# 11 --------------------------------------------------------------------
print("11 --------------------------------------------------------------")
dict_with_pupils = {"Alice": 85, "Bob": 92, "Charlie": 78, "David": 90}
sorted_dict_with_pupils = sorted(dict_with_pupils.items(), key=lambda x:x[1])
print(sorted_dict_with_pupils)

# 12 --------------------------------------------------------------------
print("12 --------------------------------------------------------------")
book = {
    "name": "Harry Potter",
    "author": "Joanne Rowling",
    "year": 2010
}
print(book)
book["year"] = 2011
book["pages"] = 987
print(book)
