class MyMeta(type):
    def __new__(cls, name, bases, dct):
        print(f"Создается класс {name}")
        return super().__new__(cls, name, bases, dct)

class MyClass(metaclass=MyMeta):
    pass