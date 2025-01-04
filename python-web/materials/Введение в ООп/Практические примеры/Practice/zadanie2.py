class City:
    def __init__(self, name, region, country, population, postal_code, phone_code):
        self._name = name
        self._region = region
        self._country = country
        self._population = population
        self._postal_code = postal_code
        self._phone_code = phone_code

    # Методы для ввода данных
    def set_name(self, name):
        self._name = name

    def set_region(self, region):
        self._region = region

    def set_country(self, country):
        self._country = country

    def set_population(self, population):
        self._population = population

    def set_postal_code(self, postal_code):
        self._postal_code = postal_code

    def set_phone_code(self, phone_code):
        self._phone_code = phone_code

    # Методы для доступа к полям
    def get_name(self):
        return self._name

    def get_region(self):
        return self._region

    def get_country(self):
        return self._country

    def get_population(self):
        return self._population

    def get_postal_code(self):
        return self._postal_code

    def get_phone_code(self):
        return self._phone_code

    # Метод для вывода всех данных
    def display_info(self):
        print(f"City: {self._name}")
        print(f"Region: {self._region}")
        print(f"Country: {self._country}")
        print(f"Population: {self._population}")
        print(f"Postal Code: {self._postal_code}")
        print(f"Phone Code: {self._phone_code}")

# Пример использования
city = City("Kyiv", "Kyiv Region", "Ukraine", 2804000, "01001", "+38044")

# Вывод всех данных о городе
city.display_info()

# Получение отдельных полей
print("Population:", city.get_population())
print("Postal Code:", city.get_postal_code())