namespace Week8_Lesson1_Ostapova;


class Program
{
    public static void Main() {
        Letter letter1 = new Letter("track1111", 0.1);
        Letter letter2 = new Letter("track2222", 0.3);

        Parcel parcel1 = new Parcel("track3333", 3, "30x20x15");
        Parcel parcel2 = new Parcel("track4444", 18, "100x50x15");

        letter1.PrintInfo();
        parcel1.PrintInfo();
        
        
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        Console.WriteLine($"");
        Console.WriteLine($"Get total cost - {myCargo.GetTotalCost()}");


    }
}

