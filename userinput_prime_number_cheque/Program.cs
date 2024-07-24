List<int> arr = new List<int>();
int count = 0;
int num = 1;

while (num > 0)
{
    Console.WriteLine("enter value 0 for insert number abd 1 for print prime number");
    int value = Convert.ToInt32(Console.ReadLine());
    switch (value)
    {
        case 0:
            Console.WriteLine("How many number do you want to test ");
            int test_number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= test_number; i++)
            {
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            arr.Add(number);
            }
            break;
        case 1:
            foreach (int i in arr)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        isprime = false;
                        break;
                    } 
                }
                if (isprime)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            num = 0;
            break;
            default:
            Console.WriteLine("you are entaring the wrong value");
            break;
    }
}
Console.Write("number of prime number are: ");
Console.WriteLine(count);