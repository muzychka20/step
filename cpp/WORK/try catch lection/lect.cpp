
//i nvalid_argument - Недопустимый аргумент :
void setPercentage(int percent) {
    if (percent < 0 || percent > 100) {
        throw invalid_argument("Процент должен быть в пределах от 0 до 100");
    }
}

// out_of_range - Выход за пределы допустимого диапазона :
void accessElement(vector<int>&vec, int index) {
    if (index < 0 || index >= vec.size()) {
        throw out_of_range("Индекс вне допустимого диапазона вектора");
    }
}

//length_error - Ошибка длины(часто связана с превышением максимально возможной длины контейнера) :
    void resizeString(string & str, size_t newSize) {
    if (newSize > str.max_size()) {
        throw length_error("Запрошенный размер превышает максимально допустимый для строки");
    }
    str.resize(newSize);
}

    //runtime_error - Ошибка времени выполнения :
    void processFile(const string& filename) {
        ifstream file(filename);
        if (!file) {
            throw runtime_error("Не удалось открыть файл");
        }
    }

    //logic_error - Логическая ошибка(при нарушении логики программы) :
        void checkLogic(int value) {
        if (value < 0) {
            throw logic_error("Значение не должно быть отрицательным в данном контексте");
        }
    }
