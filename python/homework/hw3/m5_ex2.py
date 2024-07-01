text = input("Enter some text: ").split()
words = input("Enter reserved words: ").lower().split()

for i in range(len(text)):
  if text[i].lower() in words:
    text[i] = text[i].upper()

print(" ".join(text))