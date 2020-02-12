using System;
/*Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте программу в которой создайте класс калькулятор (Calculator). 
Класс Calculator должен содержать два универсальных параметра типа T1, T2 (Calculator <T1, T2>). 
В теле класса создайте методы для сложения, вычитания и умножения, которые в качестве аргументов 
должны принимать T1, T2, и возвращать тип double (можно использовать класс Convert или приведение типов) 
*/
namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int, string> int_string = new Calculator<int, string>();
            double result = int_string.Add(10, "5,2");
            Console.WriteLine("{0} - суммирование", result);
            result = int_string.Minus(10, "5,2");   
            Console.WriteLine("{0} - вычитание", result);
            result = int_string.Product(10, "5,2");
            Console.WriteLine("{0} - умножение", result);
            result = int_string.Division(10, "5,2");
            Console.WriteLine("{0} - деление", result);
            Console.WriteLine();
            Console.ReadKey();
        }

        class Calculator<T1, T2>
        {
            public double Add (T1 value1, T2 value2) 
            {
                try
                {
                    return (Convert.ToDouble(value1) + Convert.ToDouble(value2));
                }
                catch
                {
                    Console.WriteLine("Невозможно привести к типу double");
                    return(0);
                }
            }
            public double Minus(T1 value1, T2 value2)
            {
                try
                {
                    return (Convert.ToDouble(value1) - Convert.ToDouble(value2));
                }
                catch
                {
                    Console.WriteLine("Невозможно привести к типу double");
                    return (0);
                }
            }

            public double Division(T1 value1, T2 value2)
            {
                try
                {
                    if (Convert.ToDouble(value2) != 0) 
                    {
                        return (Convert.ToDouble(value1) / Convert.ToDouble(value2));
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить не хорошо..");
                        return (0);
                    }
                }
                catch
                {
                    Console.WriteLine("Невозможно привести к типу double");
                    return (0);
                }
            }
            public double Product(T1 value1, T2 value2)
            {
                try
                {
                    return (Convert.ToDouble(value1) * Convert.ToDouble(value2));
                }
                catch
                {
                    Console.WriteLine("Невозможно привести к типу double");
                    return (0);
                }
            }

        }
    }
}
