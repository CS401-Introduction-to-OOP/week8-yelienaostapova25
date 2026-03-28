namespace Week8_Lesson1_Ostapova;

public abstract class DeliveryItem
{
    protected string _TrackingNumber;
    protected double _Weight;

    public DeliveryItem(string trackingNumber, double weight) {
        if (!string.IsNullOrWhiteSpace(trackingNumber)) {
            this._TrackingNumber = trackingNumber;
            this._Weight = weight;
        } else {
            throw new Exception("Wrong string.");
        }
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo() {
        Console.WriteLine($"");
        Console.WriteLine($"Tracking number - {this._TrackingNumber}, weight - {this._Weight}");
    }

    
}