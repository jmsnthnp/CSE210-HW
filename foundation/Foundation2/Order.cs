using System;  
using System.Collections.Generic;  

namespace OrderSystem  
{  
    public class Order  
    {  
        private List<Product> _products;  
        private Customer _customer;  

        private const decimal USAShippingCost = 5.00m;  
        private const decimal InternationalShippingCost = 35.00m;  

        public Order(Customer customer)  
        {  
            _products = new List<Product>();  
            _customer = customer;  
        }  

        public void AddProduct(Product product)  
        {  
            _products.Add(product);  
        }  

        public decimal CalculateTotalCost()  
        {  
            decimal totalCost = 0;  
            foreach (var product in _products)  
            {  
                totalCost += product.GetTotalCost();  
            }  
            decimal shippingCost = _customer.IsInUSA() ? USAShippingCost : InternationalShippingCost;  
            totalCost += shippingCost;  
            return totalCost;  
        }  

        public string GetPackingLabel()  
        {  
            string label = "Packing Label:\n";  
            foreach (var product in _products)  
            {  
                label += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";  
            }  
            return label;  
        }  

        public string GetShippingLabel()  
        {  
            string label = "Shipping Label:\n";  
            label += $"{_customer.GetCustomerName()}\n";  
            label += _customer.GetAddress().GetFullAddress();  
            return label;  
        }  
    }  
}