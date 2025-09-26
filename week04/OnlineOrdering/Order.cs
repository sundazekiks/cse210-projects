using System;

public class Order
{
    private Customer customer;

    private List<Product> products;

    private double TotalCost;
    public Order()
    {
        products = new List<Product>();
    }

    public string GenerateShippingLabel()
    {
        return $"{customer.getCustomerName()} - {customer.PassAddressToOrder()}";
    }


    public void getCustomerDetails(string _name, string prop_address, string prop_city, string prop_state, string prop_country)
    {
        customer = new Customer();
        customer.CustomerDetails(_name, prop_address, prop_city, prop_state, prop_country);
    }

    public void AddProducts(string prodName, int prodId, double prodPrice, int prodQuantity)
    {
        Product product = new Product(prodName, prodId, prodPrice, prodQuantity);

        if (product != null)
        {
            products.Add(product);
        }
    }

    public double PrintOutProducts()
    {

        List<double> PartialCost = new List<double>();

        foreach (Product unit in products)
        {
            PartialCost.Add(unit.UnitTotalCost());
        }

        double overAllPartialCost = PartialCost.Sum();

        if (customer.checkIfCustomerIsInUS())
        {
            return overAllPartialCost + 5;
        }

        return overAllPartialCost + 35;

    }

    public void packingLabel()
    {
        foreach (Product prod in products)
        {
            Console.WriteLine($"Product Name: {prod.getProductName()}, Product ID: {prod.getProductId()}");
        }
    }


}