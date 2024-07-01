# words = input()

# print(words.upper())
# print(words.lower())
# print(words.find("world"))

# list_words = words.split(" ")
# for word in list_words:
#     print(word.capitalize())

# reversed = ''
# for i in range(len(words)-1, -1, -1):
#     reversed += words[i]
# print(reversed)

# rev = words[3:1:-1]
# print(rev)


# what = input()
# replace = input()
# words = words.replace(what, replace)
# print(words)

# numbers = 0
# letters = 0
# for i in words:
#     if i.isdigit():
#         numbers = numbers + 1
#     elif i.isalpha():
#         letters = letters + 1
# print(f"letters: {letters}, digitals: {numbers}")            

# ---------------------

# list = []

# list.append(1)
# list.append("hello")
# list.append(3.14)
# list.append(True)

# print(list)

# list.remove("hello")
# list.remove(True)

# print(list)

# list.sort()

# print(list)








# month = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']
# price = [23, 45, 10, 5, 89, 51]

# current_month = 3
# last = len(price)

# month_six = []
# # month_six = ['August', 'September', 'October', 'November', 'December', 'January']

# while last:
#     month_six.append(month[current_month])
#     if current_month:
#         current_month -= 1            
#     else:
#         current_month = 11
#     last -= 1   
# month_six.reverse()     
# print(month_six)

# avg = sum(price) / len(price)

# print(avg)
# print(min(price))
# print(max(price))

# print(f"Min pricing is {min(price)} in {month_six[price.index(min(price))]}")
# print(f"Max pricing is {max(price)} in {month_six[price.index(max(price))]}")





# words = input()
# print(words.count("test"))

# words = "books book paper book book"

# word = "book"
# print(words.count(word))

# arr = words.split(" ")
# print(arr.count(word))

arr1 = [1, 'we', 2, 'hello']
arr2 = [56, 'we', 'hello', 67, 3]

common = 0

print("Commom: ")

for el in arr1:
    if el in arr2:
        print(el, end=" ")
        common += 1
        arr1.remove(el)
        arr2.remove(el)

print(f"\nAmount of common: {common}")

print(f"Unique arr1 ({len(arr1)}):", *arr1)
print(f"Unique arr2 ({len(arr2)}):", *arr2)