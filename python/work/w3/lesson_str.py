# 1. Введение в Рядки
simple_string = 'Привет, мир!'
multi_line_string = """Це
багаторядковий
рядок."""
print(simple_string)
print(multi_line_string)

# 2. Создание и Доступ к Строкам
my_string = "Hello, Python!"
first_char = my_string[0]  # H
slice_string = my_string[1:5]  # ello
print(first_char)
print(slice_string)

# 3. Операции со Строками
greeting = "Привіт, " + "світ!"
echo = "ha" * 3  # hahaha
print(greeting)
print(echo)

# 4. Методы Строк
upper_case = "python".upper()  # PYTHON
lower_case = "PYTHON".lower()  # python
found_index = "Hello world".find("world")  # 6
replaced_string = "Hello world".replace("world", "Python")  # Hello Python
words = "one,two,three".split(",")  # ['one', 'two', 'three']
joined = " ".join(words)  # 'one two three'
trimmed = "   Hello Python   ".strip()  # 'Hello Python'
print(upper_case)
print(lower_case)
print(found_index)
print(replaced_string)
print(words)
print(joined)
print(trimmed)

# 5. Форматирование Строк
name = "Мир"
formatted_old = "Привіт, %s!" % name  # Привіт, Мир!
formatted_new = "Привіт, {}!".format(name)  # Привіт, Мир!
formatted_fstring = f"Привіт, {name}!"  # Привіт, Мир!
print(formatted_old)
print(formatted_new)
print(formatted_fstring)
