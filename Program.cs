using OOP_Exercise_9;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        ShowError(ex.Message);
    }
}
static void Run()
{
    var menu = GetInt("Choose An Option:\n" +
        "1.Add Customer\n" +
        "2.Show Menu\n" +
        "3.Order Food\n" +
        "4.Show Customer Order\n" +
        "0.Exit\n");
    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0);
                break;
            }
        case 1:
            {
                var customerId = GetString("Enter Customer ID:");
                var customerAddress = GetString("Enter Customer Address:");
                FastFood.AddCustomer(customerId, customerAddress);
                break;
            }
        case 2:
            {
                Console.WriteLine("Menu:\n1.Pizza $25\n2.Pasta $15");
                var OptionToShowIngredients = GetInt("Enter The Food Number To Show Ingredients");
                FastFood.ShowIngredients(OptionToShowIngredients);
                break;
            }
        case 3:
            {
                var customerId = GetString("Enter Customer Id");
                var orderNumber = GetInt("Menu:\n1.Pizza\n2.Pasta");
                var orderCount = GetInt("Enter Order Count:");
                FastFood.AddOrder(customerId, orderNumber, orderCount);
                break;
            }
        case 4:
            {
                var customerId = GetString("Enter Customer Id");
                FastFood.ShowCustomerOrder(customerId);
                break;
            }
    }
}
static string GetString(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return input;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    var input = int.Parse(Console.ReadLine());
    return input;
}
static void ShowError(string message)
{
    Console.WriteLine("#############################");
    Console.WriteLine(message);
    Console.WriteLine("#############################");
}