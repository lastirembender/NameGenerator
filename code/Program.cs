using System;
using System.IO;

namespace NameGenerator
{
    public class Program
    {
        
        public string RandomName(int sayi, int count, string gender)
        {
            string name="";
            if (gender=="female")
            {
                string file = @"C:\\Source\Repos\NameGenerator\female.txt";
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {
                    if (count == sayi)
                    {
                        name = ln;
                    }
                    count++;

                }

            }
            else if(gender=="male")
            {
                string file = @"C:\\Source\Repos\NameGenerator\male.txt";
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {
                    if (count == sayi)
                    {
                        name = ln;
                    }
                    count++;

                }
            }

        return name; 
        }
        static int RandomNumber()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 1000);
            return sayi;
        }

        static void Main(string[] args)
        {
            String y;
            int x,z=0;
            Console.WriteLine("Please enter gender of your baby: ");
            y = Console.ReadLine();
            x = RandomNumber();
            Console.WriteLine("Name is: {0}", new Program().RandomName(x, z, y));

            
            Console.Read();
        }
    }
}
