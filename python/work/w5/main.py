sum_lambda = lambda a, b: a + b
multiply_lambda = lambda a, b: a * b
division_lambda = lambda a, b: a / b
difference_lambda = lambda a, b: a - b


def do_something(a, b, operation):
    return operation(a, b)


def calculate(a, b, operation):
    if operation == "*":
        res = do_something(a, b, multiply_lambda)
    elif operation == "+":
        res = do_something(a, b, sum_lambda)
    elif operation == "/":
        res = do_something(a, b, division_lambda)        
    elif operation == "-":
        res = do_something(a, b, difference_lambda)
    return res    


result = calculate(4, 5, "*")
# print(result)

result = calculate(4, 5, "+")
# print(result)

result = calculate(4, 5, "/")
# print(result)

result = calculate(4, 5, "-")
# print(result)


def sum_recursive(a, b):
    if a == b:
        return a
    return a + sum_recursive(a+1, b)


def sum_recursive1(a, b):
    if a == b:
        return a
    return a + b + sum_recursive(a+1, b-1)


print(sum_recursive(1, 10))
print(sum_recursive1(1, 10))


def print_symbol(amount, symbol):
    if not amount:
        return
    print(symbol, end="")
    print_symbol(amount-1, symbol)


print_symbol(5, '*')