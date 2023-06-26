// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Console.WriteLine("test1:");
Console.WriteLine(test.test1(0));
Console.WriteLine(test.test1(5));
Console.WriteLine(test.test1(6));
Console.WriteLine("-------------");

Console.WriteLine("test2:");
Console.WriteLine(test.test2(15));
Console.WriteLine(test.test2(6));
Console.WriteLine(test.test2(28));
Console.WriteLine("-------------");

Console.WriteLine("test3:");
Console.WriteLine(test.test3("231"));
Console.WriteLine(test.test3("2351"));
Console.WriteLine("-------------");

Console.WriteLine("test4:");
Console.WriteLine(test.test4(10,2,5));
Console.WriteLine(test.test4(12,4,4));
Console.WriteLine(test.test4(6,2,2));
Console.WriteLine("-------------");



public class test
{

    public static int test1(int num)
    {
        int result = 1;
        int i = 1;
        while (i <= num)
        {
            result *= i;
            i++;
        }
        return result;
    }

    public static bool test2(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum == num;
    }

    public static int test3(string input)
    {
        string inputCoppy = input;
        int minValue = Convert.ToInt32(input);
        int currentValue = 0;
        int index = -1;
        for (int i = 0; i < input.Length; i++)
        {
            input = input.Remove(i, 1);
            currentValue = Convert.ToInt32(input);
            if (minValue > currentValue)
            {
                minValue = currentValue;
                index = i;
            }
            input = inputCoppy;
        }

        return index;
    }

    public static int test4(int n, int c, int m)
    {
        int sokeo = n / c;
        int vokeo = sokeo;
        while (vokeo >= m)
        {
            sokeo++;
            vokeo = vokeo - m + 1;
        }
        return sokeo;
    }
}

