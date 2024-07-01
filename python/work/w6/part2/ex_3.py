dictionary = {
    1: "a",
    2: "b",
    3: "c"
}

try:
    
    for item in dictionary.items():
        print(*item, sep=': ')

    find = dictionary[3]
    print(find)
        
    dictionary[1] = 'A'
    print(dictionary[1])

    user_choose = int(input("Find item with  key: "))
    print(dictionary[user_choose])

    user_choose = int(input("Delete item with  key: "))
    del dictionary[user_choose]

    for item in dictionary.items():
        print(*item, sep=': ')

except KeyError as e:
    print(f"Not valid key! Exception: {e}")
