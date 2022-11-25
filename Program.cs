using System;

namespace programmeringsolympiaden_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TorAmount = 0;
            int MorAmount = 0;
            int tortid;
            int mortid;
            int Carrots = 40;
            
            Console.Write("Please input the amount of time Tor and his mother take to eat, starting with Tor: ");
            tortid = Convert.ToInt32(Console.ReadLine());
            mortid = Convert.ToInt32(Console.ReadLine());
            tortid = tortid * 1000;
            mortid = mortid * 1000;
            Console.WriteLine("Calculating...");
            if (Carrots >= 0){
                //Jag har fastnat här borta och visste inte hur jag skulle göra
            }
        }
    }
}
