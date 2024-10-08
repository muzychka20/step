# Цикл while виконується, поки умова істинна

count = 0  # Ініціалізація лічильника

# Виконувати цикл, поки count менше 5
while count < 5:
    print("count =", count)
    count += 1  # Збільшуємо count на 1 при кожній ітерації

print("Цикл завершено")

#--------------------------
# Цикл for проходить через кожен елемент у послідовності

# Ітерація через список чисел
for number in [1, 2, 3, 4, 5]:
    print("Число:", number)

print("Цикл завершено")

#--------------------------
# Використання break для виходу з циклу

# Ітерація з 1 до 10
for i in range(1, 11):
    if i == 6:
        break  # Вихід з циклу, коли i дорівнює 6
    print("i =", i)

print("Цикл перервано на i =", i)

#--------------------------
# Використання continue для пропуску поточної ітерації

# Ітерація з 1 до 5
for j in range(1, 6):
    if j % 2 == 0:  # Пропустити парні числа
        continue
    print("Непарне число:", j)

print("Цикл завершено")

#--------------------------
# Вічний цикл без умови виходу (Потрібно бути обережним!)

# Ініціалізація змінної
k = 0

# Вічний цикл
while True:
    print("Цикл виконується")
    k += 1

    # Умова для виходу з циклу
    if k == 3:
        print("Умова для виходу виконана")
        break

print("Цикл завершено")

#--------------------------

# Вкладені цикли: один цикл всередині іншого

# Зовнішній цикл
for x in range(1, 4):
    print("Зовнішній цикл, x =", x)

    # Внутрішній цикл
    for y in range(1, 4):
        print("   Внутрішній цикл, y =", y)

print("Цикли завершено")

