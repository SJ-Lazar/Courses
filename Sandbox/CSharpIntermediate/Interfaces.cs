public class Interfaces
{
    //To Build Loosly coupled components 
    //To achieve abstraction
    //To hide implementation details of a class
    //changes should not break other components
    //Interface is a contract
    //Interface improves testability of the application

    public void Run()
    {
        
    }

    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f) return order.TotalPrice * 0.1f;
            return 0;
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { get; set; }
        public Shipment Shipment { get; set; }
    }

    public class Shipment
    {
        public DateTime ShippingDate { get; set; }
        public float Cost { get; set; }
    }
}

