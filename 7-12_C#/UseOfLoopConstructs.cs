using System;
namespace Bank
{
    class Customer
    {
        static void Main(string[] args)
        {
            string[] customerName = new string[3];
            string[] city = new string[3];

            int[] age = new int[3];
            char[] gender = new char[3];
            string cityName = "Ha Noi";
            int total = 0;
            int i = 0;
            do
            {
                Console.Write("Enter the name of customer : ");
                customerName[i] = Console.ReadLine();
                Console.Write("Enter the age : ");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter gender [M/F] : ");
                gender[i] = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter city : ");
                city[i] = Console.ReadLine();
                Console.WriteLine();
                i++;
            } while(i < customerName.Length);

            Console.WriteLine("Customer Details : ");
            Console.WriteLine("Name     \tAge       \tGender     \tCity");
            for(i = 0; i < customerName.Length; i++)
            {
                Console.Write("{0} \t{1} \t", customerName[i], age[i]);
                if (gender[i] == 'M' || gender[i] == 'm')
                    Console.Write("Male \t");
                else
                    Console.Write("Female \t");
                Console.WriteLine("{0}", city[i]);
            }
            Console.WriteLine("\nNames of Customer : ");
            foreach (string names in customerName)
            {
                Console.WriteLine("{0} ", names);
            }
            Console.Write("\nEnter the name of city whose records you want to view : ");
            Console.WriteLine("Name     \tAge       \tGender       \tCity");
            i = 0;
            while (i < customerName.Length)
            {
                if (city[i] == cityName)
                {
                    Console.Write("{0} \t{1} \t", customerName[i], age[i]);
                    if (gender[i] == 'M' || gender[i] == 'm')
                        Console.Write("Male \t");
                    else
                        Console.Write("Female \t");
                    Console.WriteLine("{0}", city[i]);
                    total++;
                }
                i++;
            }
            Console.WriteLine("No.  of customer in {0} : {1}", cityName, total);
        }
    }
}