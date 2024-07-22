using System.Text;

public class Order
{
    private List<Product> _products;

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;

        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += _customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}, Cost Per Unit: {product.GetPricePerUnit()}, Quantity: {product.GetQuantity()}");
        }

        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}