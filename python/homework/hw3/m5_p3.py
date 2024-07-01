import random

lower_limit = 1
upper_limit = 20
list_length = 10

list_1 = [random.randint(lower_limit, upper_limit) for _ in range(list_length)]
list_2 = [random.randint(lower_limit, upper_limit) for _ in range(list_length)]

list_3 = list_1 + list_2

list_4 = []
list_4 += [element for element in list_1 if element not in list_4]
list_4 += [element for element in list_2 if element not in list_4]

list_5 = list(set(list_1) & set(list_2))

list_6 = []
list_6 += [element for element in list_1 if element not in list_2]
list_6 += [element for element in list_2 if element not in list_1]

list_7 = [min(list_1), max(list_1), min(list_2), max(list_2)]

print("List 1: ", *list_1)
print("List 2: ", *list_2)
print("List 3 (contains elements of both lists): ", *list_3)
print("List 4 (contains the elements of both lists without repetitions): ", *list_4)
print("List 5 (contains elements common to two lists): ", *list_5)
print("List 6 (contains only unique elements of each of the lists): ", *list_6)
print("List 7 (contains the minimum and maximum value of each of the lists): ", *list_7)  