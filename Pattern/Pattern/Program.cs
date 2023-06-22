namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory sedanFactory = new SedanFactory();
            IReleaseNewModel sedan = sedanFactory.Create();
            ICarFactory coupeFactory = new CoupeFactory();
            IReleaseNewModel coupe = coupeFactory.Create();
        }
    }
}