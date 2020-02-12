using System;
//Является ли сравнение time и null в выражении if  ? Почему?
namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? time = null;
            if (time == null)
            {
                Console.Write("Time - '{0}'", time);
            }
        }

    }
    /*Так как в исходном коде видно, что DateTime - это структура, следует это значемый тып, а не ссылочный.
      Поэтому null применить не можем. Можем привести к ссылочному после чего можем сравнивать с null.
    */

}
