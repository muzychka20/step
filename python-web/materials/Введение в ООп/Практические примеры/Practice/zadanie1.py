class Person:
    def __init__(self, full_name, birth_date, phone, city, country, address):
        """
        Инициализирует новый объект Person с базовыми данными.
        
        Аргументы:
        full_name -- полное имя (ФИО) человека
        birth_date -- дата рождения в формате 'YYYY-MM-DD'
        phone -- контактный телефон
        city -- город проживания
        country -- страна проживания
        address -- домашний адрес
        """
        self.full_name = full_name
        self.birth_date = birth_date
        self.phone = phone
        self.city = city
        self.country = country
        self.address = address

    def input_data(self):
        """
        Метод для ввода данных человека. Запрашивает значения у пользователя и обновляет соответствующие поля.
        """
        self.full_name = input("Введите ФИО: ")
        self.birth_date = input("Введите дату рождения (YYYY-MM-DD): ")
        self.phone = input("Введите контактный телефон: ")
        self.city = input("Введите город: ")
        self.country = input("Введите страну: ")
        self.address = input("Введите домашний адрес: ")

    def display_data(self):
        """
        Метод для вывода данных человека. Показывает значения всех полей.
        """
        print(f"ФИО: {self.full_name}")
        print(f"Дата рождения: {self.birth_date}")
        print(f"Телефон: {self.phone}")
        print(f"Город: {self.city}")
        print(f"Страна: {self.country}")
        print(f"Домашний адрес: {self.address}")

    def set_full_name(self, full_name):
        """
        Метод для установки ФИО.
        """
        self.full_name = full_name

    def get_full_name(self):
        """
        Метод для получения ФИО.
        """
        return self.full_name

    def set_birth_date(self, birth_date):
        """
        Метод для установки даты рождения.
        """
        self.birth_date = birth_date

    def get_birth_date(self):
        """
        Метод для получения даты рождения.
        """
        return self.birth_date

    def set_phone(self, phone):
        """
        Метод для установки контактного телефона.
        """
        self.phone = phone

    def get_phone(self):
        """
        Метод для получения контактного телефона.
        """
        return self.phone

    def set_city(self, city):
        """
        Метод для установки города проживания.
        """
        self.city = city

    def get_city(self):
        """
        Метод для получения города проживания.
        """
        return self.city

    def set_country(self, country):
        """
        Метод для установки страны проживания.
        """
        self.country = country

    def get_country(self):
        """
        Метод для получения страны проживания.
        """
        return self.country

    def set_address(self, address):
        """
        Метод для установки домашнего адреса.
        """
        self.address = address

    def get_address(self):
        """
        Метод для получения домашнего адреса.
        """
        return self.address


# Пример использования класса Person
person = Person("Иван Иванов", "1990-01-01", "+123456789", "Киев", "Украина", "ул. Бандеры, д. 1")
person.display_data()  # Выводим все данные о человеке

# Обновляем некоторые данные
person.set_phone("+987654321")
print(f"Обновленный телефон: {person.get_phone()}")