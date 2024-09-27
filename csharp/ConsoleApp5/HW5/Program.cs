/*
Задание: Управление заказами в магазине
Создайте консольное приложение, моделирующее работу интернет-магазина.
В приложении должно быть реализовано несколько классов для товаров, клиентов и заказов.
Необходимо также предусмотреть обработку исключений при совершении операций с заказами.

Условия:

Класс Product(Товар):
Свойства: Id, Name, Price, Stock (количество на складе).
Метод Purchase(int quantity): уменьшает количество товара на складе при покупке. Если товара недостаточно, выбрасывается исключение InsufficientStockException.

Класс Customer (Клиент):
Свойства: Id, Name, Balance (сумма денег на счету).
Метод PlaceOrder(Product product, int quantity): создаёт заказ на покупку товара. Если денег недостаточно, выбрасывается исключение InsufficientFundsException.

Класс Order (Заказ):
Свойства: OrderId, Customer, Product, Quantity.
Метод ProcessOrder(): обрабатывает заказ, вызывая методы покупки у товара и списывая деньги со счёта клиента. Если какие-либо операции не выполняются из-за исключений, заказ отклоняется.

Класс исключений InsufficientStockException: выбрасывается, когда на складе недостаточно товара.

Класс исключений InsufficientFundsException: выбрасывается, когда на счету клиента недостаточно денег для покупки.

Требования:
Обработка исключений в методе ProcessOrder(). Если возникает ошибка, вывести сообщение об ошибке и отклонить заказ.
Реализовать несколько тестовых сценариев: один успешный заказ, один заказ с недостатком товара и один заказ с недостатком средств у клиента.
*/


using HW5;
using HW5.Exceptions;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Products
        Product laptop = new Product(1, "Laptop", 1500, 5);
        Product phone = new Product(2, "Phone", 800, 2);

        // Customers
        Customer customer1 = new Customer(1, "Sam", 5000);
        Customer customer2 = new Customer(2, "Kate", 700);

        // Success
        Order order1 = new Order(1, customer1, laptop, 2);
        order1.ProcessOrder();
        Console.WriteLine();

        // Not enough products in stock
        Order order2 = new Order(2, customer1, phone, 3);
        order2.ProcessOrder();
        Console.WriteLine();

        // Not enough money
        Order order3 = new Order(3, customer2, laptop, 1);
        order3.ProcessOrder();
        Console.WriteLine();
    }
}