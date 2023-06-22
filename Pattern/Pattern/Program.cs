using System;
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
    interface ICarFactory
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




}