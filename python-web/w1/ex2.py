"""
Задание 3
Создайте класс «Страна». Необходимо хранить в
полях класса: название страны, название континента,
количество жителей в стране, телефонный код страны,
название столицы, название городов страны. Реализуйте 
методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса. 
"""
class Country:
    def __init__(self, name, continent, population, tel, capital, cities):
        self._name = name
        self._continent = continent
        self._population = population
        self._tel = tel
        self._capital = capital
        self._cities = cities

    @property
    def name(self):
        return self._name 
    
    @name.setter
    def name(self, value):
        self._name = value

    @property
    def continent(self):
        return self._continent 
    
    @continent.setter
    def continent(self, value):
        self._continent = value 
    
    @property
    def population(self):
        return self._population

    @population.setter
    def population(self, value):
        self._population = value

    @property
    def tel(self):
        return self._tel

    @tel.setter
    def tel(self, value):
        self._tel = value

    @property
    def capital(self):
        return self._capital

    @capital.setter
    def capital(self, value):
        self._capital = value       
        
    @property
    def cities(self):        
        return ", ".join(self._cities)

    @cities.setter
    def cities(self, value):
        self._cities = value   

Ukraine = Country(name="Ukraine", continent="Europa", population="37m", tel="+38", capital="Kyiv", cities=["Dnipro", "Lviv"])
print(Ukraine.capital, Ukraine.cities, Ukraine.continent, Ukraine.name, Ukraine.population, Ukraine.tel)
            

"""
Задание 4
Создайте класс «Дробь». Необходимо хранить в полях
класса: числитель и знаменатель. Реализуйте методы класса
для ввода данных, вывода данных, реализуйте доступ к
отдельным полям через методы класса. Также создайте
методы класса для выполнения арифметических операций (сложение, вычитание, умножение, деление, и т.д.).

Keyword arguments:
argument -- description
Return: return_description
"""

class Fraction:
    def __init__(self, numerator, denominator):
        self._numerator = numerator
        self._denominator = denominator

    @property
    def numerator(self):
        return self._numerator
    
    @property
    def denominator(self):
        return self._denominator   

    def enter_data(self):
        self._numerator = int(input("Numerator: "))
        self._denominator = int(input("Denominator: "))

    def show_fraction(self):
        print(f"{self._numerator}\n-\n{self._denominator}")    

    def set_numerator(self, value):
        self._numerator = value    
        
    def set_denominator(self, value):
        self._denominator = value

    def mult(self, fraction):
        self._numerator *= fraction.numerator
        self._denominator *= fraction.denominator
        self.show_fraction()

    def divide(self, fraction):
        self._numerator *= fraction.denominator
        self._denominator *= fraction.numerator
        self.show_fraction()    

    def add(self, fraction):
        common = self._denominator * fraction.denominator
        self._numerator = (common / self._denominator * self._numerator) + (common / fraction._denominator * fraction.numerator)
        self._denominator = common
        self.show_fraction()     

    def division(self, fraction):
        common = self._denominator * fraction.denominator
        self._numerator = (common / self._denominator * self._numerator) - (common / fraction._denominator * fraction.numerator)
        self._denominator = common
        self.show_fraction()           



# start
f1 = Fraction(2, 3)
f2 = Fraction(1, 4)
f1.show_fraction()
print('---------')
f2.show_fraction()
print('---------')

# multiply
print('multiply')
f1 = Fraction(2, 3)
f2 = Fraction(1, 4)
f1.mult(f2)
print('---------')



# divide
print('divide')
f1 = Fraction(2, 3)
f2 = Fraction(1, 4)
f1.divide(f2)
print('---------')



# add
print('add')
f1 = Fraction(2, 3)
f2 = Fraction(1, 4)
f1.add(f2)
print('---------')



# division
print('division')
f1 = Fraction(2, 3)
f2 = Fraction(1, 4)
f1.division(f2)
print('---------')
