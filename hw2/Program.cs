using System;
/*Используя Visual Studio, создайте проект по шаблону Console Application.      
Создайте программу в которой создайте класс MyClass<T>, содержащий статический фабричный метод - T FacrotyMethod(),
который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).
*/
namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int>.FactoryMethod();
            MyClass<char>.FactoryMethod();
            MyClass<double>.FactoryMethod();
            MyClass<string>.FactoryMethod();
            Console.ReadKey();
        }

        public class MyClass<T>
        {
            public T type;
            static public T FactoryMethod()
            {
                MyClass<T> type_obj = new MyClass<T>();
                Console.WriteLine(type_obj.GetType());
                return type_obj.type;
            }
        }
    }
}
