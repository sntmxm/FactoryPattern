namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory sedanFactory = new SedanFactory();
            Car sedan = sedanFactory.Create();
            ICarFactory coupeFactory = new CoupeFactory();
            Car coupe = coupeFactory.Create();
        }
    }
}