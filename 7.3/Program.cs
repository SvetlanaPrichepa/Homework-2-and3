// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Enter n:");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter m:");
        int m = Convert.ToInt32(Console.ReadLine());
        int [,]arr=new int [n, m];
        Random ran = new Random();
        int sum = 0;
        float middle = 0;

        for (int i=0; i < n; i++)
        {
            for(int j=0; j<m; j++)
            {
                arr[i, j] = ran.Next(0, 100);


                    sum += arr[i, j];

                 middle = sum /( m*n);

                Console.Write(arr[i, j] + "\t");


            }
            Console.WriteLine();

        }
        Console.WriteLine("middle=" + middle);

        Console.ReadLine();