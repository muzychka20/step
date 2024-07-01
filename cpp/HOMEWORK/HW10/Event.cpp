#include "Event.hpp"

//Задание 4 : Регистрация на событие
//Задача : Создайте функцию для регистрации участников на событие.Функция должна принимать возраст участника и его идентификационный номер.Если возраст не позволяет участвовать в событии(например, возраст меньше 18 лет), функция должна генерировать исключение invalid_argument.Если идентификационный номер уже зарегистрирован, генерируйте logic_error.

void Event::registerParticipant(Participant* participant) {
    try {
        if (participant->age < 18) {
            throw invalid_argument("Only 18+");
        }
        if (alreadyInList(participant->INN)) {
            throw logic_error("Already in list!");
        }
        participants.push_back(participant);
        cout << "Successfully registered!\n";
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
    } catch(logic_error& error) {
        cerr << error.what() << endl;
    }
}

bool Event::alreadyInList(string& INN) {
    for (const Participant* part : participants) {
        if (part->INN == INN) return true;
    }
    return false;
}
