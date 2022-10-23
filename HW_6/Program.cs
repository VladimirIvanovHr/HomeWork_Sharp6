    void Zadacha41()
    // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    {
    Console.WriteLine("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray (numbers);
    Console.WriteLine("Содержание массива");
    PrintArray (numbers);
    Counter (numbers);


        void FillArray (int[] num)
        {   
            for (int i = 0; i < num.Length; i++)
            {
            Console.WriteLine($"Введите число {i+1}: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
            
            // Random random = new Random();
            // num[i] = random.Next(100, 1000 );
            }
        }

        
        void Counter(int[] num)
        {
        int count = 0;
        for (int i = 0; i < size; i++)
        {
    
            if (num[i] > 0)
        {   
            count++;
        }
        }
        Console.WriteLine("Количество чисел больше 0 -> " + count);
        }
        
        void PrintArray (int[] num)
        {

        for (int i = 0; i < size; i++)
        {
            Console.Write(num[i] + "\t"); 
        }
        Console.WriteLine();
        }

        }

    void Zadacha43()

    // Напишите программу, которая найдёт точку пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    {
    Console.WriteLine("Введите k для первого уравнения: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b для первого уравнения: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k для первого уравнения: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b для первого уравнения: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Function();

    void Function()
        {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечния ({x};{y})");
        }
    }

    Zadacha43();