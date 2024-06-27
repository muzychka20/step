cmake_minimum_required(VERSION 3.5)

project(ClassWork LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

add_executable(ClassWork main.cpp
    car.h car.cpp
    color.h color.cpp
    sedan.h sedan.cpp
    pickup.h pickup.cpp
    truck.h truck.cpp
    bus.h bus.cpp
    store.h store.cpp
    menu.h menu.cpp

    pickupfactory.h pickupfactory.cpp
    sedanfactory.h sedanfactory.cpp
    truckfactory.h truckfactory.cpp
    busfactory.h busfactory.cpp)

include(GNUInstallDirs)
install(TARGETS ClassWork
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
)
