// 3. Создайте базовый класс Pet с виртуальным свойством Sound, которое возвращает звук, который издает животное.
// Реализуйте производные классы Dog, Cat и Bird. В каждом классе переопределите свойство Sound, 
// чтобы оно возвращало соответствующие звуки.
// Напишите программу, которая создает массив объектов Pet и выводит звуки каждого животного.

namespace HW3_2;

class Program
{
    static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>{
            new Bird(),
            new Cat(),
            new Dog()
        };
        foreach (var pet in pets)
        {
            Console.WriteLine(pet.Sound);
        }
    }
}
