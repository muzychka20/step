row = input("Enter a row: ").lower().replace(" ", "")
reversed_row = row[::-1]
print("Row is a palindrome") if row == reversed_row else print("Row is not a palindrome")