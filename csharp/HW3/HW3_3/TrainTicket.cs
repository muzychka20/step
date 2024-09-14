namespace HW3_3;

public class TrainTicket : Ticket
{   
    private decimal distance;

    public TrainTicket(decimal _basePrice, decimal _distance)
    {
        basePrice = _basePrice;
        distance = _distance;
    }

    public override decimal GetPrice()
    {        
        return basePrice + (distance * (decimal)0.1);
    }
}