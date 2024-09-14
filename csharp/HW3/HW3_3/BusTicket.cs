namespace HW3_3;

public class BusTicket : Ticket
{   
    public BusTicket(decimal _basePrice)
    {
        basePrice = _basePrice;
    }

    public override decimal GetPrice()
    {        
        return basePrice;
    }
}
