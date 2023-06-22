namespace Pattern
{
    public interface IReleaseNewModel
    {
        void Release();
    }
    public class Sedan : IReleaseNewModel
    {
        public void Release() => Console.WriteLine("Released sedan");
    }
    public class Coupe : IReleaseNewModel
    {
        public void Release() => Console.WriteLine("Released coupe");
    }
    public interface ICarFactory
    {
        IReleaseNewModel Create();
    }

    public class SedanFactory : ICarFactory
    {
        public IReleaseNewModel Create() => new Sedan();
    }

    public class CoupeFactory : ICarFactory
    {
        public IReleaseNewModel Create() => new Coupe();
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory sedanFactory = new SedanFactory();
            IReleaseNewModel sedan = sedanFactory.Create();
            ICarFactory coupeFactory = new CoupeFactory();
            IReleaseNewModel coupe = coupeFactory.Create();
            sedan.Release();
            coupe.Release();
        }
    }
}