for i in range(3):
    time = int(input("time = "))
    if 6 <= time < 10:
        print("Breakfast:")
        print("-Tea\n-Porridge\n-Cake")
    elif 10 <= time < 15:
        print("Dinner:")
        print("-Coffee\n-Mashed potatoes\n-Salad")
    elif 15 <= time < 20:
        print("Supper")
        print("-Milk\n-Rice\n-Muffin")
    elif 20 <= time <= 24 or 0 <= time < 6:
        print("Go to sleep!")
    else:
        print("Incorrect value!")