
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }

