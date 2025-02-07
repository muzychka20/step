#9. Неизменяемость и производительность
#Поскольку кортежи неизменяемы, они более 
#производительны по сравнению со списками, 
#особенно если требуется хранить неизменяемые данные. 
#В некоторых случаях кортежи занимают меньше памяти.

#10. Использование кортежей в качестве ключей словарей
#Кортежи могут использоваться в качестве ключей в словарях 
#в отличие от списков), так как они неизменяемы.
my_dict = {(1, 2): "Point A", (3, 4): "Point B"}
print(my_dict[(1, 2)])  # Выведет "Point A"