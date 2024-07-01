import random
from colorama import Fore
from pynput.keyboard import Key, Listener
import os


size = 4
board = []
index_of_empty_i = 0
index_of_empty_j = 0


left_up_corner = Fore.GREEN + "\u2554" + Fore.RESET
horizontal_line = Fore.GREEN + "\u2550" + Fore.RESET
right_up_corner = Fore.GREEN + "\u2557" + Fore.RESET
horizontal_down = Fore.GREEN + "\u2566" + Fore.RESET
horizontal_up = Fore.GREEN + "\u2569" + Fore.RESET
right_down_corner = Fore.GREEN + "\u255D" + Fore.RESET
left_down_corner = Fore.GREEN + "\u255A" + Fore.RESET
vertical_right = Fore.GREEN + "\u2560" + Fore.RESET
vertical_line = Fore.GREEN + "\u2551" + Fore.RESET
cross = Fore.GREEN + "\u256C" + Fore.RESET
vertical_left = Fore.GREEN + "\u2563" + Fore.RESET


def set_up_board():
    tags = [i for i in range(size**2)]
    board = []
    for _ in range(size):
        line = []
        for _ in range(size):
            tag_index = random.randint(0, len(tags)-1)
            tag = tags[tag_index]
            line.append(tag)
            tags.remove(tag)
        board.append(line)
    return board


def clear_screen():
    os.system('cls' if os.name == 'nt' else 'clear')


def print_up_border():
    print(left_up_corner, end='')
    for i in range(size):
        print(horizontal_line * 6, end='')
        if i != size-1:
            print(horizontal_down, end='')
    print(right_up_corner)


def print_down_border():
    print(left_down_corner, end='')
    for i in range(size):
        print(horizontal_line * 6, end='')
        if i != size-1:
            print(horizontal_up, end='')
    print(right_down_corner)


def print_empty_row():
    print(vertical_line + (" " * 6 + vertical_line) * size)


def print_row_with_number(array, i):
    print(vertical_line, end='')
    for j in range(size):
        array[j] = array[j] if array[j] else ''
        if size * i + j + 1 == array[j]:
            print(Fore.CYAN, end='')
        else:
            print(Fore.RED, end='')
        print("  {:<2}  {}".format(array[j], vertical_line), end='')
    print()


def print_separator():
    print(vertical_right, end='')
    for i in range(size):
        print(horizontal_line * 6, end='')
        if i != size - 1:
            print(cross, end='')
    print(vertical_left)


def print_board(board):
    print_up_border()
    for i in range(size):
        print_empty_row()
        print_row_with_number(board[i], i)
        print_empty_row()
        if i != size - 1:
            print_separator()
    print_down_border()


def hide_input():
    """
    On unix systems.
    It doesn't show what the input is on the console but display just the prints
    """
    os.system("stty -echo")  # turn off - hide
    # os.system("stty echo") # turn on - show


def get_indexes_of_empty(board):
    for i in range(size):
        for j in range(size):
            if not board[i][j]:
                return i, j


def swipe_up():
    global index_of_empty_i, index_of_empty_j
    if index_of_empty_i < size - 1:
        board[index_of_empty_i][index_of_empty_j] = board[index_of_empty_i + 1][index_of_empty_j]
        board[index_of_empty_i + 1][index_of_empty_j] = 0
        index_of_empty_i += 1


def swipe_down():
    global index_of_empty_i, index_of_empty_j
    if index_of_empty_i > 0:
        board[index_of_empty_i][index_of_empty_j] = board[index_of_empty_i-1][index_of_empty_j]
        board[index_of_empty_i-1][index_of_empty_j] = 0
        index_of_empty_i -= 1


def swipe_right():
    global index_of_empty_i, index_of_empty_j
    if index_of_empty_j > 0:
        board[index_of_empty_i][index_of_empty_j] = board[index_of_empty_i][index_of_empty_j-1]
        board[index_of_empty_i][index_of_empty_j-1] = 0
        index_of_empty_j -= 1


def swipe_left():
    global index_of_empty_i, index_of_empty_j
    if index_of_empty_j < size - 1:
        board[index_of_empty_i][index_of_empty_j] = board[index_of_empty_i][index_of_empty_j+1]
        board[index_of_empty_i][index_of_empty_j+1] = 0
        index_of_empty_j += 1


def on_key_release(key): 
    if key == Key.right:
        swipe_right()
    elif key == Key.left:
        swipe_left()
    elif key == Key.up:
        swipe_up()
    elif key == Key.down:
        swipe_down()
    elif key == Key.esc:
        return False
    clear_screen()
    print_board(board)
    if check_victory(board):
        print("You won!")     
        return False
    

def check_victory(board):    
    for i in range(size):
        for j in range(size):
            tag = board[i][j]
            tag = size ** 2 if not tag else tag
            if size * i + j + 1 != tag:                
                return False            
    return True

    
def play_game():    
    global board, index_of_empty_i, index_of_empty_j    
    hide_input()
    board = set_up_board()
    index_of_empty_i, index_of_empty_j = get_indexes_of_empty(board)
    
    clear_screen()
    print_board(board)  
    with Listener(on_release=on_key_release) as listener:
        listener.join()
       
    
play_game()