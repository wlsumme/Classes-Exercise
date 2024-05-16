namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();


            //Properties
            myCar.year = 2019;
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            //Fields
            myCar.haveTint = true;
            myCar.numberOfWheels = 4;

            Console.WriteLine($"My car is a {myCar.year} {myCar.Make} {myCar.Model}. Does have cool tinted windows? {myCar.haveTint}." +
               
                $"\n" +
                $"And strangely enough it has {myCar.numberOfWheels} wheels!!!!!!");

        }
    }
}
