class LinesOfCode
{
    static readonly Dictionary<int, string> customers = new()
        {
            { 1,"Vahid"},{ 2,"John"},{ 3,"Mari"},{ 4,"David"}
        };
    public decimal Calculate(int id, string order)
    {
        string customer = customers.FirstOrDefault(x => x.Key == id).Value;

        decimal shippingCost = 0;
        if (customer != "John")//check customer business
        {
            shippingCost = 10;
        }

        decimal totalOrderCosts = 0;
        if (order == "Coca")//check order business
        {
            totalOrderCosts = 100;
        }

        decimal totalCosts = totalOrderCosts + shippingCost;
        return totalCosts;
    }

    //public decimal Calculate(int id, string order)
    //{
    //    string customer = "Vahid";//repository.GetCustomer(id)

    //    decimal shippingCost = CalculateShippingCosts(customer);
    //    decimal totalOrderCosts = CalculateOrderCosts(order);
    //    decimal totalCosts = CalculateTotalCosts(totalOrderCosts, shippingCost);

    //    return totalCosts;
    //}

    //private decimal CalculateShippingCosts(string customer)
    //{
    //    decimal shippingCost = 0;
    //    if (customer != "Ali")//check customer business
    //    {
    //        shippingCost = 10;
    //    }
    //    return shippingCost;
    //}

    //private decimal CalculateOrderCosts(string order)
    //{
    //    decimal totalOrderCosts = 0;
    //    if (order == "Coca")//check order business
    //    {
    //        totalOrderCosts = 100;
    //    }
    //    return totalOrderCosts;
    //}

    //private decimal CalculateTotalCosts(decimal orderCosts, decimal shippingCosts) => orderCosts + shippingCosts;
}