namespace Week8_Lesson1_Ostapova;

public class Parcel : DeliveryItem
{
    private string _Dimensions;

    public Parcel(string trackingNumber, double weight, string dimensions) :base(trackingNumber, weight){
        if (!string.IsNullOrWhiteSpace(dimensions)) {
            this._Dimensions = dimensions;
        } else {
            throw new Exception("Wrong string.");
        }
    }
    
    public override double CalculateCost() {
        return 50 + (this._Weight * 25);
    }

    public override void PrintInfo() {
        base.PrintInfo();
        Console.WriteLine($"Dimentions of {this._TrackingNumber} - {this._Dimensions}");
    }
}