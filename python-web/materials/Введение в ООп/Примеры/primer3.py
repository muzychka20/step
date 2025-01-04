class Example:
    def __init__(self):
        self.public = "Доступен всем"
        self._protected = "Доступен в подклассах"
        self.__private = "Только для класса"

obj = Example()
print(obj.public)
print(obj._protected)