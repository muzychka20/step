#5. Кортежи как возвращаемое значение функции
#Функции могут возвращать несколько значений, используя кортежи.

def calculate(x, y):
    sum_result = x + y
    difference = x - y
    return (sum_result, difference)

result = calculate(10, 5)
print(result)  # Выведет (15, 5)