using System;

namespace NameGenerator
{
    public class Program
    {
        
        public string RandomName(int sayi, string gender)
        {
            string[] maleNames = { "Akif", "Adnan","Alp","Alper","Behzat","Baybars","Cemil","Demir","Efe","Ege","Hilmi","Kıvanc","Murat" };
            string[] femaleNames = { "Asya", "Ayse", "Beril", "Ece","Berfu","Defne","Dilara","Dilber","Ecrin","Gamze","Hacer","Silan", "Zulal" };

            String name = "";
            switch (gender)
            {
                case "female":
                    name += femaleNames[sayi];
                    break;
                case "male":
                    name += maleNames[sayi];
                    break;
            }
            return name;
        }
        static int RandomNumber()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 13);
            return sayi;
        }

        static void Main(string[] args)
        {
            String y;
            int x;
            Console.WriteLine("Please enter gender of your baby: ");
            y = Console.ReadLine();
            x = RandomNumber();
            Console.WriteLine("Name is: {0}", new Program().RandomName(x, y));
        }
    }
}
