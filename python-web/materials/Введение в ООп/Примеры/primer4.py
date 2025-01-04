class Animal:
    def sound(self):
        print("Издает звук")

class Dog(Animal):
    def sound(self):
        print("Гав-гав")

dog = Dog()
dog.sound()