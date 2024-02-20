// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// declare the function to process the program
void CalculateWaterBill()
{
    Console.WriteLine("Enter Customer's Full Name: ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please select customer type:");
    Console.WriteLine("Enter 1 if you are a household customer, then press enter");
    Console.WriteLine("Enter 2 if you are a governmental administrative customer, then press enter");
    Console.WriteLine("Enter 3 if you are a manufacturing unit customer, then press enter");
    Console.WriteLine("Enter 4 if you are a business customer, then press enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // household customer
        // request number of family members
        Console.WriteLine("Enter the number of family members");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter the water meter reading of last month");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the water meter reading of this month");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("The water bill for your household is: {0}", money);
            }
            else
            {
                Console.WriteLine("The water meter reading of last month is not greater than this month");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // governmental administrative customer
        Console.WriteLine("Please enter the water meter reading of last month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading of this month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("The water bill for governmental administrative customer is: {0}", m);
        }
        else
        {
            Console.WriteLine("The water meter reading of last month is not greater than this month");
        }
    }
    else if (typeCustomer == 3)
    {
        // manufacturing unit customer
    }
    else if (typeCustomer == 4)
    {
        // business customer
    }
    else
    {
        Console.WriteLine("Please enter the correct customer type");
    }
}
// run the program
CalculateWaterBill();