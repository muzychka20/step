import random

max_length = 100
length_of_part = 10

def get_array():
    arr = []
    for _ in range(max_length):
        arr.append(random.randint(1, 100))
    return arr    


# def get_sums(array):
#     arr_of_sums = []
#     print("Parts:")
#     for i in range(max_length - length_of_part + 1):
#         sum_of_part = 0
#         print(i, end=") ")
#         for j in range(i, i + length_of_part):                
#             sum_of_part += array[j]
#             print(array[j], end=" ")
#         arr_of_sums.append(sum_of_part)
#         print()
#     return arr_of_sums 

def get_index_min(array):
    index = 0
    sum_of_part = 0

    print("Parts:")
    print("0)", end=" ")
    for i in range(0, 10):
        print(array[i], end=" ")        
        sum_of_part += array[i]
    print()
    min_of_part = sum_of_part 

    for i in range(1, max_length - length_of_part + 1):
        sum_of_part = 0  
        print(i, end=") ")  
        for j in range(i, i + length_of_part):                
            print(array[j], end=" ")
            sum_of_part += array[j]
        if sum_of_part < min_of_part:
            min_of_part = sum_of_part  
            index = i
        print()

    return index, min_of_part 
        

    



# get_min = lambda array_of_sums: min(array_of_sums)


# get_index_of_min = lambda array_of_sums, min_of_sum_parts: array_of_sums.index(min_of_sum_parts)


array = get_array()
print("Original array:\n", array)

# array_of_sums = get_sums(array)

# min_of_sum_parts = get_min(array_of_sums)

# index_of_min = get_index_of_min(array_of_sums, min_of_sum_parts)

# print("Min sum of parts:\n", min_of_sum_parts)
# print("Index of min sum of parts:\n", index_of_min)

index, min = get_index_min(array)
print(f"\nmin: {min}, index of start: {index}")

# print("Fin res (elements):")
# for i in range(index_of_min, index_of_min + length_of_part):
#     print(array[i], end=" ")

# print("\nFin res (indexes):")
# for i in range(index_of_min, index_of_min + length_of_part):
#     print(i, end=" ")




print("\nFin res (elements):")
for i in range(index, index + length_of_part):
    print(array[i], end=" ")
print()

print("\nFin res (indexes):")
for i in range(index, index + length_of_part):
    print(i, end=" ")