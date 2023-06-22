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



}