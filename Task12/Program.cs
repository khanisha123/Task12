using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {

            Task.Counter = 0;
            String word1 = "Salam Kamran. Necəsən Kamran";
            
            

            foreach (var item in word1)
            {
                if (item == "Kamran")
                {
                    Task.Counter++;
                }
            }
            
            Console.WriteLine(Task.Counter);
        }
    }
}
