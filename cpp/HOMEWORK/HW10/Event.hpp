#ifndef Event_hpp
#define Event_hpp

#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include "Participant.hpp"

using namespace std;

class Event {
private:
    bool alreadyInList(string& INN);

public:
    vector<Participant*> participants;
    void registerParticipant(Participant* participant);
};

#endif
