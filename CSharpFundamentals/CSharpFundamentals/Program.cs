namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero Pudge = new Hero();
            Pudge.HeroName = "Pudge";
            Pudge.Level = 16;
            Pudge.Generate();

            Hero Rubick = new Hero();
            Rubick.HeroName = "Rubick";
            Rubick.Level = 16;
            Rubick.Generate();

            string[] heroList = new string[5];
            heroList[0] = Pudge.HeroName;
            heroList[1] = Rubick.HeroName;


        }
    }

    public class Hero 
    {
        public string HeroName;
        public int Level;
        public void Generate() 
        {
            Console.WriteLine($"Level {Level} {HeroName} has been generated.");
        }

    }
}