from colorama import Fore
import os
import random
import time
import threading


# Resourses at the beginning of the game
acre_attributes = {}
price_list = {}
sell_price = {}
pricing_limits = {}
coefficients_limits = {}
food_for_person = 0
win_year = 0
random_events = {}


def error_file_not_found():
    """Show error message: File not found"""
    print(Fore.RED + "File not found" + Fore.RESET)
    time.sleep(1)
    exit()


def get_resources():
    """Get resources for start"""
    resourses = {}
    try:
        with open('./source/resources.csv', 'r') as file:
            file.readline()
            while True:
                line = file.readline()[:-1]
                if not line:
                    break
                array = line.split(',')
                resourses[array[0]] = float(array[1])
        return resourses
    except FileNotFoundError:
        error_file_not_found()


def get_acre_atributes():
    """Get acre atributes for start"""
    try:
        with open('./source/acre_atribute.csv', 'r') as file:
            file.readline()
            while True:
                line = file.readline()[:-1]
                if not line:
                    break
                array = line.split(',')
                acre_attributes[array[0]] = float(array[1])
    except FileNotFoundError:
        error_file_not_found()


def get_pricing():
    """Get pricing for start"""
    try:
        with open('./source/pricing.csv', 'r') as file:
            file.readline()
            while True:
                line = file.readline()[:-1]
                if not line:
                    break
                array = line.split(',')
                price_list[array[0]] = float(array[1])
                sell_price[array[0]] = float(array[2])
    except FileNotFoundError:
        error_file_not_found()


def get_pricing_limits():
    """Get pricing limits for game"""
    try:
        with open('./source/pricing_limits.csv', 'r',  encoding="utf-8") as file:
            file.readline()
            while True:
                line = file.readline()[:-1]
                if not line:
                    break
                array = line.split(',')
                pricing_limits[array[0]] = float(array[1])                       
    except FileNotFoundError:
        error_file_not_found()


def get_events():
    """Get events for game"""
    try:
        with open('./source/events.csv', 'r') as file:
            names = file.readline()[:-1].split(',')
            while True:
                line = file.readline()[:-1]
                if not line:
                    break
                array = line.split(',')                                
                random_events[array[0]] = {
                    names[1]: int(array[1]),
                    names[2]: array[2]
                }                   
    except FileNotFoundError:
        error_file_not_found()


def get_coefficients_limits():
    """Get coefficients limits for game"""
    try:
        with open('./source/coef_limits.csv', 'r') as file:
            file.readline()
            while True:
                line = file.readline()[:-1]
                if not line:
                    break
                array = line.split(',')
                coefficients_limits[array[0]] = float(array[1])            
    except FileNotFoundError:
        error_file_not_found()


def get_parameters():
    """Get get parameters food_for_person and win_year for game"""
    global food_for_person, win_year
    try:        
        with open('./source/parameters.csv', 'r') as file:
            file.readline()
            food_for_person = float(file.readline()[:-1].split(',')[1])
            win_year = int(file.readline()[:-1].split(',')[1])        
    except FileNotFoundError:
        error_file_not_found()


def get_start_values():
    """Initialize start values for game"""    
    functions = [get_acre_atributes, get_pricing, get_pricing_limits, get_events, get_coefficients_limits, get_parameters]
    threads = []
    
    for worker_func in functions:
        thread = threading.Thread(target=worker_func)
        threads.append(thread)
        thread.start()
    
    for thread in threads:
        thread.join()
                    
    return get_resources()


def raise_exception_no_such_point():
    """Raise exception when user choice is out of range"""
    raise Exception(Fore.RED + "No such point!" + Fore.RESET)


def print_status(resources):
    """Displays information about the amount of resources"""
    print(f"{Fore.MAGENTA}Зерно: {resources['grain']} {Fore.CYAN} Люди: {resources['people']} {Fore.LIGHTYELLOW_EX} Золото: {resources['gold']} {Fore.GREEN} Земля: {resources['land']}({resources['sown_land']}) {Fore.RED} Год: {resources['year']} {Fore.RESET}")


def print_prices():
    """Displays information about price of resourses """
    print(
        f"{Fore.MAGENTA}Зерно: {price_list['grain']}/{sell_price['grain']} {Fore.CYAN}Люди: {price_list['people']} {Fore.GREEN} Земля: {price_list['land']}/{sell_price['land']}{Fore.RESET}")


def update_price_lists():
    """Update prices"""
    low = int(pricing_limits['low'])
    hight = int(pricing_limits['hight'])
    price_list['grain'] = random.randint(low, hight)
    sell_price['grain'] = random.randint(low, hight)
    price_list['land'] = random.randint(low, hight)
    sell_price['land'] = random.randint(low, hight)
    price_list['people'] = random.randint(low, hight)


def print_land_menu_operations():
    """Displays information about menu """
    clear_screen()
    print(Fore.WHITE + "Операции с землей:")
    print(Fore.MAGENTA + "1. Купить")
    print(Fore.CYAN + "2. Продать")
    print(Fore.YELLOW + "3. Засеять")
    print(Fore.LIGHTBLACK_EX + "4. Вернуться назад" + Fore.RESET)


def sowing_land_is_allowed(amount, resources):
    """Checks the possibility of buying a certain amount of land """
    if amount > resources['land']:
        print(Fore.RED + "Недостаточно земли")
        return False
    elif amount * acre_attributes['people'] > resources['people']:
        print(Fore.RED + "Недостаточно людей")
        return False
    elif amount * acre_attributes['grain'] > resources['grain'] + acre_attributes['grain'] * resources['sown_land']:
        print(Fore.RED + "Недостаточно зерна")
        return False
    return True


def sow_land(resources):
    """Implements the ability for user to sow the land """
    while True:
        amount = int(input(Fore.WHITE + "Сколько акров земли засеять: "))
        if sowing_land_is_allowed(amount, resources):
            if resources['sown_land']:
                resources['grain'] += (resources['sown_land'] - amount) * acre_attributes['grain']
            else:
                resources['grain'] -= amount * acre_attributes['grain']
            resources['sown_land'] = amount
            break


def land_operations(resources):
    """Displays operation with land"""
    while True:
        print_land_menu_operations()
        subchoice = int(input("Выберите операцию для земли: "))
        if subchoice > 4 or subchoice < 1:
            raise_exception_no_such_point()
        clear_screen()
        if subchoice == 1:
            buy_land(resources)
        elif subchoice == 2:
            sell_land(resources)
        elif subchoice == 3:
            sow_land(resources)
        elif subchoice == 4:
            break


def end_of_game(resources):
    """Displays information about resourses at the end of the game"""
    if resources['year'] == win_year:
        clear_screen()
        print(Fore.RED + 'Вы выиграли!')
        return True
    elif resources['percentage_of_deaths'] >= 30:
        clear_screen()
        print(Fore.RED + "Вы проиграли!")
        return True
    else:
        return False


def buy_land(resources):
    """Implements the ability for user to buy land"""
    while True:
        acres_to_buy = int(input(Fore.WHITE + "Сколько акров земли вы хотите купить? "))
        if buying_land_is_allowed(acres_to_buy, resources.get('gold', 0)):
            total_land_price = acres_to_buy * price_list['land']
            resources['land'] += acres_to_buy
            resources["gold"] -= total_land_price
            break


def buying_land_is_allowed(amount, gold):
    """Checks the possibility of buying a certain amount of land"""
    total_land_price = amount * price_list['land']
    if gold >= total_land_price:
        return True
    else:
        print(Fore.RED + "Покупка земли невозможна из-за нехватки золота.")
        return False


def sell_land(resources):
    """Implements the ability for user to sell land"""
    while True:
        acres_to_sell = int(input(Fore.WHITE + "Сколько акров земли вы хотите продать? "))
        if selling_land_is_allowed(acres_to_sell, resources['land'], resources['sown_land']):
            total_acres_price = acres_to_sell * price_list['land']
            resources['land'] -= acres_to_sell
            resources['gold'] += total_acres_price
            break


def selling_land_is_allowed(amount, land, sown_land):
    """Checks the possibility of selling a certain amount of land"""
    if land >= amount and land - amount >= sown_land:
        return True
    else:
        print(Fore.RED + "У вас нет земли для продажи.")
        return False


def print_menu():
    """Displays menu status"""
    print("Выберите пункт меню:")
    print(f"{Fore.MAGENTA}1. Зерно")
    print(f"{Fore.CYAN}2. Люди ")
    print(f"{Fore.GREEN}3. Земля")
    print(f"{Fore.BLUE}4. Следующий год")
    print(f"{Fore.LIGHTBLACK_EX}5. Выйти {Fore.RESET}")


def print_people_menu_operations():
    """Displays menu with operations with people"""
    clear_screen()
    print("Операции с людьми:")
    print(f"{Fore.MAGENTA}1. Нанять")
    print(f"{Fore.LIGHTBLACK_EX}2. Вернуться назад{Fore.RESET}")


def people_operations(resources):
    """Implements interaction with the user who selects an operation for people"""
    while True:
        print_people_menu_operations()
        user_people = int(input("Выберите операцию для людей: "))
        if user_people > 2 or user_people < 1:
            raise_exception_no_such_point()
        clear_screen()
        if user_people == 1:
            people_hire(resources)
        elif user_people == 2:
            break


def hire_people_is_allowed(gold, amount):
    """Checks the possibility of hiring a certain number of people"""
    if amount < 0:
        print(f"{Fore.RED}Некорректное число{Fore.RESET}")
        return False
    cost_per_person = price_list.get("people")
    total = amount * cost_per_person
    if gold >= total:
        return True
    else:
        print(f"{Fore.RED}Недостаточно средств{Fore.RESET}")
        return False


def people_hire(resources):
    """Implements the ability for user to hire people"""
    while True:
        hier = int(input("Сколько людей нанять: "))
        if hire_people_is_allowed(resources['gold'], hier):
            resources['people'] += hier
            resources['gold'] -= hier * price_list.get("people")
            break


def clear_screen():
    """Clears screen of information"""
    os.system('cls' if os.name == 'nt' else 'clear')


def print_grain_menu_operations():
    """Displays information about menu """
    clear_screen()
    print("Операции с зерном:")
    print(f"{Fore.MAGENTA}1. Продать")
    print(f"{Fore.LIGHTBLUE_EX}2. Купить")
    print(f"{Fore.LIGHTBLACK_EX}3. Вернуться назад{Fore.RESET}")


def grain_operations(resources):
    """Displays operation with grain"""
    while True:
        print_grain_menu_operations()
        user_grain = int(input("Выберите операцию для зерна: "))
        if user_grain > 3 or user_grain < 1:
            raise_exception_no_such_point()
        clear_screen()
        if user_grain == 1:
            sell_grain(resources)
        elif user_grain == 2:
            buy_grain(resources)
        elif user_grain == 3:
            break


def sell_grain(resources):
    """Implements the ability for user to sell grain"""
    while True:
        grain_to_sell = int(input(Fore.WHITE + "Сколько центнеров зерна вы хотите продать: "))
        if selling_grain_is_allowed(grain_to_sell, resources.get('grain', 0)):
            total_grain_price = grain_to_sell * sell_price['grain']
            resources['grain'] -= grain_to_sell
            resources['gold'] += total_grain_price
            break


def selling_grain_is_allowed(amount, grain):
    """Checks the possibility of selling a certain amount of grain"""
    if grain >= amount and grain > 0:
        return True
    else:
        print(Fore.RED + "Недостаточно зерна для продажи. ")
        return False


def buy_grain(resources):
    """Implements the ability for user to buy grain"""
    while True:
        grain_to_buy = int(input(Fore.WHITE + "Сколько центненров зерна купить: "))
        if buying_grain_is_allowed(resources['gold'], grain_to_buy):
            resources['grain'] += grain_to_buy
            resources['gold'] -= grain_to_buy * price_list.get("grain")
            break


def buying_grain_is_allowed(gold, amount):
    """Checks the possibility of buying a certain amount of grain"""
    total_grain_price = amount * price_list['grain']
    if gold >= total_grain_price:
        return True
    else:
        print(Fore.RED + "Недостаточно золота. ")
        return False


def get_coefficients():
    """Displays information about coefficients limits"""
    low = coefficients_limits['low']
    hight = coefficients_limits['hight']
    K1 = round(random.uniform(low, hight), 2)
    K2 = round(random.uniform(low, hight), 2)
    return K1, K2


def confirm_year_change(resources):
    """Requests confirmation from user to change the year"""
    if resources['sown_land']:
        print(Fore.WHITE + "Действительно вы хотите перейти на слейдущий год?, y/n?")
    else:
        print(Fore.WHITE + "Действительно вы хотите перейти на слейдущий год без посеяной земли?, y/n?")
    return input()


def gathering_harvest(resources):
    """Implements the ability for user to gather the harvest"""
    harvested_grain = resources['sown_land'] * acre_attributes['harvest']
    resources['grain'] += harvested_grain
    resources['sown_land'] = 0


def population_census(resources):
    """Implements the ability for user to census the population"""
    K1, K2 = get_coefficients()
    population_growth = round(resources['people'] * K1)
    amount_deathes = round(resources['people'] * K2)
    if random.random() < 1:
        amount_deathes += handle_random_event(resources)
    if resources['people'] * food_for_person > resources['grain']:
        people_must_die = (resources['people'] * food_for_person - resources['grain']) / food_for_person
        resources['grain'] = 0
        amount_deathes += people_must_die
    else:
        resources['grain'] -= round(resources['people'] * food_for_person)
        resources['people'] += population_growth
    if amount_deathes > resources['people']:
        amount_deathes = resources['people']
    resources['percentage_of_deaths'] = round((amount_deathes / resources['people']) * 100)
    resources['people'] -= amount_deathes
    return population_growth, amount_deathes


def birth_death_statistics(population_growth, amount_deathes, resources):
    """Displays statistics of people"""
    print(
        f"Людей родилось: {population_growth}\nЛюдей умерло: {amount_deathes}\nПроцент умерших: {resources['percentage_of_deaths']}%")


def handle_random_event(resources):
    event = random.choice(list(random_events.keys()))
    event_name_ru = random_events[event]["name_ru"]
    event_death_rate = random_events[event]["rate"]
    death_amount = round(resources["people"] * (event_death_rate / 100))
    clear_screen()
    print(f"{Fore.RED}{event_name_ru}! {death_amount} человек погибло. {Fore.RESET}")
    _ = input()
    return death_amount


def go_to_next_year(resources):
    """User approval allows you to move on to the next year, while reaping the harvest"""
    clear_screen()
    if confirm_year_change(resources) == "y":
        resources['year'] += 1
        gathering_harvest(resources)
        population_growth, amount_deathes = population_census(resources)
        clear_screen()
        birth_death_statistics(population_growth, amount_deathes, resources)
        update_price_lists()
        _ = input()


def play_game():
    """Implements an interactive game between the user and the computer using previously written functions"""
    resources = get_start_values()
    while True:
        clear_screen()
        if end_of_game(resources):
            break
        print_status(resources)
        print_prices()
        print_menu()
        try:
            choice = int(input("Ваш выбор: "))
            if choice > 5 or choice < 1:
                raise_exception_no_such_point()
            if choice == 1:
                grain_operations(resources)
            elif choice == 2:
                people_operations(resources)
            elif choice == 3:
                land_operations(resources)
            elif choice == 4:
                go_to_next_year(resources)
            elif choice == 5:
                break
        except ValueError:
            print(Fore.RED + "Invalid input!" + Fore.RESET)
            time.sleep(1)
        except Exception as e:
            print(e)
            time.sleep(2)


play_game()
