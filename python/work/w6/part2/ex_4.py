import os

def fill_dictionary():
    dictionary = {}
    try:
        amount = int(input("Enter amount of items in dictionary: "))
        for _ in range(amount):
            key, value = map(str, input("Enter key and value: ").split())
            dictionary[key] = value
    except ValueError as e:
        print(f"Exception: {e}")  
    return dictionary         


def print_dictionary(dictionary):
    for item in dictionary.items():
        print(*item, sep=': ')


def find_item(dictionary):
    try:
        user_key = input("Enter key: ")
        return dictionary[user_key]
    except KeyError as e:
        print(f"Not find key: {e}")


def update_dictionary(dictionary):
    user_key, user_value = map(str, input("Enter key and value: ").split())
    dictionary[user_key] = user_value


def delete_from_dictionary(dictionary):
    try:
        key = input("Enter ket: ")
        del dictionary[key]
    except KeyError as e:
        print(f"Not find key: {e}")


def print_menu():
    print("1. Fill dictionary")
    print("2. Find item by key")
    print("3. Update dictionary")
    print("4. Delete item by key")
    print("5. Print dictionary")
    print("6. Exit")


def clear_screen():
    os.system('cls' if os.name == 'nt' else 'clear')
    

def main():
    dictionary = {}
    while True:        
        print_menu()
        choose = int(input())
        if choose == 1:
            dictionary = fill_dictionary()
        elif choose == 2:
            print(find_item(dictionary))
        elif choose == 3:
            update_dictionary(dictionary)
        elif choose == 4:
            delete_from_dictionary(dictionary)
        elif choose == 5:
            print_dictionary(dictionary)   
        elif choose == 6:
            break    

main()