namespace Week8_Lesson1_Ostapova;

public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight) {
        //
    }

    public override double CalculateCost() {
        return 15 + (this._Weight * 10);
    }
}