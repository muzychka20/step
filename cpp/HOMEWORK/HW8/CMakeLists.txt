cmake_minimum_required(VERSION 3.5)

project(HW8 LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

add_executable(HW8 main.cpp
    animal.h animal.cpp
    horse.h horse.cpp
    cat.h cat.cpp
    dog.h dog.cpp)

include(GNUInstallDirs)
install(TARGETS HW8
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
)
