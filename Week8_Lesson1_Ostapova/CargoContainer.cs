namespace Week8_Lesson1_Ostapova;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> listTypeT = new List<T>();
    
    
    public void AddItem(T item) {
        listTypeT.Add(item);
    }
    
    public double GetTotalCost() {
        double sum = 0;
        foreach (T i in listTypeT) {
            sum += i.CalculateCost();
        }

        return sum;
    }
    
}