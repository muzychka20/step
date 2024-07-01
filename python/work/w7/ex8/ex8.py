with open('ex8.txt', 'r') as file:
    amount_chars = amount_lines = 0
    while True:
        line = file.readline()[:-1]
        if not line:
            break
        amount_lines += 1
        amount_chars += len(line)
print("amount_chars: ", amount_chars)
print("amount_lines: ", amount_lines)