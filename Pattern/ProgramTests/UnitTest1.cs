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

        public class ConsoleCapture : IDisposable
        {
            private StringWriter stringWriter;
            private TextWriter originalOutput;

            public ConsoleCapture()
            {
                stringWriter = new StringWriter();
                originalOutput = Console.Out;
                Console.SetOut(stringWriter);
            }

            public string Output => stringWriter.ToString();

            public void Dispose()
            {
                Console.SetOut(originalOutput);
                stringWriter.Dispose();
            }
        }

        [Test]
        public void SedanRelease()
        {

            IReleaseNewModel sedan = new Sedan();
            using (var consoleOutput = new ConsoleCapture())
            {
                sedan.Release();
                string output = consoleOutput.Output;
                StringAssert.Contains("Released sedan", output);
            }
        }

        [Test]
        public void CoupeRelease()
        {
            IReleaseNewModel coupe = new Coupe();
            using (var consoleOutput = new ConsoleCapture())
            {
                coupe.Release();
                string output = consoleOutput.Output;
                StringAssert.Contains("Released coupe", output);
            }
        }
    }


}