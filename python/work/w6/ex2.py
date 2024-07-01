try:
    a = float(input("a = "))
    b = float(input("b = "))
    div = a / b
    if div < 1:
        raise Exception("[0 .. 1)")
    if div < 2:
        raise Exception("[1 .. 2)")
    if div < 3:
        raise Exception("[2 .. 3)")
except Exception as e:
    print(f"Exception: {e}")
