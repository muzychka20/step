// 3. Создайте абстрактный класс Ticket с абстрактным методом GetPrice().
// Реализуйте производные классы BusTicket, TrainTicket и FlightTicket, которые определяют стоимость билета 
// в зависимости от типа транспорта и других факторов.
// Напишите программу, которая создает различные типы билетов и выводит их стоимость на экран.

namespace HW3_3;

class Program
{
    static void Main(string[] args)
    {
        List<Ticket> tickets = new List<Ticket>{
            new BusTicket(500),
            new FlightTicket(500, false),
            new TrainTicket(500, 150),
        };

        foreach (Ticket ticket in tickets)
        {
            Console.WriteLine($"{ticket.GetType().Name}: {ticket.GetPrice()}");
        }
    }
}
