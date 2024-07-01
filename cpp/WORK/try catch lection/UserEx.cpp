//Пользовательское исключение для специфической бизнес - логики:
class BusinessRuleViolation : public exception {
private:
    string message;
public:
    BusinessRuleViolation(const string& msg) : message(msg) {}
    const char* what() const noexcept override {
        return message.c_str();
    }
};

//Пользовательское исключение для ошибок в API :
class ApiException : public exception {
private:
    int errorCode;
public:
    ApiException(int code, const string& msg) : exception(msg.c_str()), errorCode(code) {}
    int getErrorCode() const { return errorCode; }
};

//Пользовательское исключение для ограничений доступа :
class AccessDeniedException : public exception {
public:
    const char* what() const noexcept override {
        return "Доступ запрещен";
    }
};

//Пользовательское исключение для валидации данных :
class DataValidationException : public exception {
private:
    string message;
public:
    DataValidationError(const string& msg) : message(msg) {}
    const char* what() const noexcept override {
        return message.c_str();
    }
};

//Пользовательское исключение для операций с файлами :
class FileOperationException : public exception {
private:
    string message;
public:
    FileOperationException(const string& msg) : message(msg) {}
    const char* what() const noexcept override {
        return message.c_str();
    }
};
