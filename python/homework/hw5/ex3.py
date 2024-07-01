from colorama import Fore
import os


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

size = 8


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
        if isinstance(array[j], str):
            print(Fore.CYAN + " {} {}".format(array[j], vertical_line), end='')
        else:    
            print(Fore.CYAN + "  {:<2}  {}".format(array[j], vertical_line), end='')
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
    
    
def is_valid(i, j, chess_board):
    if i >= 0 and i < size and j >= 0 and j < size:
        if chess_board[i][j] == -1:
            return True
    return False


def get_start_position(chess_board):
    start_x, start_y = map(int, input(f"Enter start position (1 - {size}): ").split())
    start_x -= 1
    start_y -= 1
    chess_board[start_x][start_y] = 0
    return start_x, start_y


def get_chess_coordinates(size):
    coordinares_chess_board = []
    for i in range(size):
        line = []
        for j in range(size):
            cell_array = [str(num) for num in [i + 1, j + 1]]
            cell_coordinates = '  '.join(cell_array)
            line.append(cell_coordinates)
        coordinares_chess_board.append(line)
    return coordinares_chess_board


def knight_tour(chess_board, i, j, step_count, x_move, y_move):
    if step_count == size * size:        
        return True

    for k in range(0, 8):
        next_i = i + x_move[k]
        next_j = j + y_move[k]

        if is_valid(next_i, next_j, chess_board):
            chess_board[next_i][next_j] = step_count
            if knight_tour(chess_board, next_i, next_j, step_count + 1, x_move, y_move):
                return True
            chess_board[next_i][next_j] = -1

    return False


def start_knight_tour():
    clear_screen()
    
    chess_board = [[-1] * size for _ in range(size)]
    coordinares_chess_board = get_chess_coordinates(size)

    print_board(coordinares_chess_board)
    start_x, start_y = get_start_position(chess_board)
    
    clear_screen()
        
    x_move = [2, 1, -1, -2, -2, -1, 1, 2]
    y_move = [1, 2, 2, 1, -1, -2, -2, -1]

    if knight_tour(chess_board, start_x, start_y, 1, x_move, y_move):
        print_board(chess_board)


start_knight_tour()
