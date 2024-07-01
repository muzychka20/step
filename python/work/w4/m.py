

def even_number(number):
    return False if number % 2 else True


def reverse(string):
    return string[::-1]


def replace_item(list, w1, w2):
    list = ' '.join(list).replace(w1, w2)
    return list.split(' ')


def my_sum(x, y):
    return x + y


def my_multiply(x, y):
    return x * y


def my_difference(x, y):
    return x - y


def my_division(x, y):
    return x / y


def calculate(a, b, operation):
    if operation == "*":
        c = my_multiply(a, b)
    elif operation == "/":
        c = my_division(a, b)
    elif operation == "+":
        c = my_sum(a, b)
    elif operation == "-":
        c = my_difference(a, b)
    return c


def calc_sum(size, number):
    part = 0
    for _ in range(int(size / 2)):
        part += number % 10
        number //= 10
    return part    


def lucky_number(number):
    t = number
    size = 0
    while t:
        t //= 10
        size += 1
    if even_number(size):
        part1 = calc_sum(size, number)      
        number //= (10 ** int((size / 2)))       
        part2 = calc_sum(size, number)       
        return part1 == part2
    else:
        return "Wrong input!"    


def find_elemnt_in_list(list, number):
    return number in list


def count_elemnts(list):
    positive = negative = even = odd = 0
    for el in list:
        if el < 0:
            negative += 1
        else:
            positive += 1

        if el % 2:
            odd += 1
        else:
            even += 1
    return positive, negative, even, odd                


def create_list(list):
    result = []
    for i in range(my_difference(len(list), 1)):    
        if even_number(list[i]):
            result.append(my_multiply(list[i], list[my_sum(i, 1)]))
        else:
            result.append(my_sum(list[i], list[i+1]))
    return result
  

def factorial(n):
    if n <= 1:
        return n
    return n * factorial(n-1)


def fact(n):
    res = 1
    while n:
        res *= n
        n -= 1
    return res
        

def draw(symbol, direction, key):
    if direction == "horizontal":
        print(symbol * key)
    elif direction == "vertical":
        print((symbol + "\n") * key)


draw("*", "horizontal", 5)
draw("*", "vertical", 5)

print("Factorial(1): ", factorial(5))
print("Factorial(2): ", fact(5))

print("1)", even_number(4))

print("2.1)", reverse("hello world"))
print("2.2)", reverse(["hello", "world", 2, 1]))

print("3)", replace_item(["hello", "world"], "hello", "hi"))

print("4)", calculate(2,3,"-"))

print("5)", lucky_number(123321))

print("6)", find_elemnt_in_list([1,2,3,4,5], -4))

pos, neg, even, odd = count_elemnts([-4, 43, 1, 4, 785, 74, -2])
res = {
    "Positive": pos,
    "Negative": neg,
    "Even": even,
    "Odd": odd
}

print("7)", res)

print("8)", create_list([1,2,3,4,5]))