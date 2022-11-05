// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32( Console.ReadLine());
// int y = x*x;
// Console.WriteLine("Вот посчитали квардрат введенного вами числа и это число - "+y);
// if (x==8)
// {
//     Console.WriteLine("Вы ввели 8");
// }
// else Console.WriteLine("Вы ввели ввели число отличное от 8");
// int i = 0;
// while (i<x)
// {
//     Console.WriteLine($"счетчик цикла равен {i}"); //$ позволяет вывести значение переменной
//     i=i+1;  
// }
// // //  Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N
// // // до N.
// // // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// // // 2 -> " -2, -1, 0, 1, 2"
// // Console.WriteLine("Введите натуральное число ");
// // int x=Convert.ToInt32( Console.ReadLine());
// // int count = -x;
// // while (count < x)
// // {
// //     //Console.Write( count+" " );  
// //     Console.Write( $"{count},  " );
// //     count = count + 1 ;
// // }

// // Console.Write( count );


// //  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// // 456 -> 6
// // 782 -> 2
// // 918 -> 8
// // Console.WriteLine("Введите трехзначное число ");
// // int x=Convert.ToInt32( Console.ReadLine());
// // int y = x%10;
// // Console.WriteLine(y);
// // Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да
// // a = 2, b = 10 -> нет
// // a = 9, b = -3 -> да
// // a = -3 b = 9 -> нет
// Console.WriteLine("Введите натуральное число a ");
// int a=Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите натуральное число b ");
// int b=Convert.ToInt32( Console.ReadLine());
// if (a==b*b) Console.WriteLine("число а квадрат числа b");
// else Console.WriteLine("число а  не квадрат числа b");
//     // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//     // 3 -> Среда
//     // 5 -> Пятница 
// try
//     {
//     Console.WriteLine("Введите натуральное число от 1 до 7 ");
//     int x=Convert.ToInt32( Console.ReadLine());
//     if (x==1) Console.WriteLine("Понедельник");
//     else if (x == 2) Console.WriteLine("Вторник");
//     else if (x == 3) Console.WriteLine("Среда");
//     else if (x == 4) Console.WriteLine("четверг");
//     else if (x == 5) Console.WriteLine("пятница");
//     else if (x == 6) Console.WriteLine("суббота");
//     else if (x == 7) Console.WriteLine("воскресенье");  
//     else Console.WriteLine("столько не бывает дней в неделе");
//     }
// catch
// {
//     Console.WriteLine("вы ввели чушь"); 
// }
