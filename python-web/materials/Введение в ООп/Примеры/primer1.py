class Car:
    def __init__(self, brand, model):
        self.brand = brand
        self.model = model

    def start(self):
        print(f"{self.brand} {self.model} запускается.")

my_car = Car("Toyota", "Camry")
my_car.start()