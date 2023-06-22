using Pattern;

namespace ProgramTests
{
    [TestFixture]
    public class CarFactoryTests
    {
        [Test]
        public void SedanFactoryCreateSedanType()
        {
            ICarFactory sedanFactory = new SedanFactory();
            IReleaseNewModel sedan = sedanFactory.Create();
            Assert.IsInstanceOf<Sedan>(sedan);
        }

        [Test]
        public void CoupeFactoryCreateCoupeType()
        {
            ICarFactory coupeFactory = new CoupeFactory();
            IReleaseNewModel coupe = coupeFactory.Create();
            Assert.IsInstanceOf<Coupe>(coupe);
        }

    }


}