class Cat:
    def speak(self):
        return "Мяу"

class Dog:
    def speak(self):
        return "Гав"

def animal_sound(animal):
    print(animal.speak())

animal_sound(Cat())
animal_sound(Dog())