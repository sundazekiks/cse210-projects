using System;

public class Product
{
    private string _prod_name;
    private int _prod_id;
    private double _prod_price;
    private int _prod_quantity;

    private double unitTotalCost;

    public Product(string prodName, int prodId, double prodPrice, int prodQuantity)
    {
        _prod_name = prodName;
        _prod_id = prodId;
        _prod_price = prodPrice;
        _prod_quantity = prodQuantity;

        unitTotalCost = _prod_price * _prod_quantity;
    }

    public double UnitTotalCost()
    {
        return unitTotalCost;
    }

    public string getProductName()
    {
        return _prod_name;
    }

    public int getProductId()
    {
        return _prod_id;
    }
}