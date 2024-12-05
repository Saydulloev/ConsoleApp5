using System;


class Program
{ 

    static void Main()

    {

        Console.WriteLine(CountBits(4100));

        Console.WriteLine(CountBits(1));

        Console.WriteLine(CountBits(32100000));
        Console.WriteLine(DigitalRoot(16));

        Console.WriteLine(DigitalRoot(942));

        Console.WriteLine(Persistence(39));

        Console.WriteLine(Persistence(9));

        Console.WriteLine(Persistence(999));
    }



    static int CountBits(int num)

    {

        string binaryRepresentation = Convert.ToString(num, 2);

        int count = 0;



        foreach (char c in binaryRepresentation)

        {

            if (c == '1')

            {

                count++;

            }

        }



        return count;

    }



    


    //2
    static int Persistence(int num)

    {

        int count = 0;

        while (num >= 10)

        {

            int product = 1;

            while (num > 0)

            {

                product *= num % 10;

                num /= 10;

            }

            num = product;

            count++;

        }



        return count;

    }






    //3 
    static int DigitalRoot(int num)

    {

        while (num >= 10)

        {

            int sum = 0;

            while (num > 0)

            {

                sum += num % 10;

                num /= 10;

            }

            num = sum;

        }

        

        return num;

    }

}