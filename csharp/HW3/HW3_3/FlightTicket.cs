namespace HW3_3;

public class FlightTicket : Ticket
{
    private bool international;

    public FlightTicket(decimal _basePrice, bool _international)
    {
        basePrice = _basePrice;
        international = _international;
    }

    public override decimal GetPrice()
    {
        return international ? basePrice * 2 : basePrice + basePrice * (decimal)0.5;
    }
}
