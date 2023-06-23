using Pattern;

namespace ProgramTests
{
    [TestFixture]
    public class CarFactoryTests
    {
        [Test]
        public void SedanFactoryCreateCar()
        {
            ICarFactory sedanFactory = new SedanFactory();
            Car car = sedanFactory.Create();
            Assert.IsInstanceOf<Sedan>(car);
        }

        [Test]
        public void CoupeFactoryCreateCar()
        {
            ICarFactory coupeFactory = new CoupeFactory();
            Car car = coupeFactory.Create();
            Assert.IsInstanceOf<Coupe>(car);
        }
    }

}


