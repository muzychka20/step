text = input("Enter some text: ")
text = text.replace("...", ".")
amount = text.count(".") + text.count("?") + text.count("!")
print("Amount of sentences: ", amount)