using MaximumNumber;
using NUnit.Framework;


namespace MaximumNumberTest
{
    public class Tests
    {
        MaximumInteger Max = new MaximumInteger();
        [Test]
        public void GivenFirstNumberMax_WhenAct_ReturnFirstNumber()
        {
            int firstNumber = 100;
            int secondNumber = 80;
            int thirdNumber = 90;
            int expected = 100;
            int maxNumber = Max.MaxInteger(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expected, maxNumber);
        
        }
        [Test]
        public void GivenSecondNumberMax_WhenAct_ReturnSecondNumber()
        {
        
        int firstNumber = 50;
        int secondNumber = 60;
        int thirdNumber = 40;
        int expected = 60;

        
        int maxNumber = Max.MaxInteger(firstNumber, secondNumber, thirdNumber);

        
        Assert.AreEqual(expected, maxNumber);
        }
        [Test]
        public void GivenThirdNumberMax_WhenAct_ReturnThirdNumber()
        {
            
            int firstNumber = 60;
            int secondNumber = 50;
            int thirdNumber = 100;
            int expected = 100;

            
            int maxNumber = Max.MaxInteger(firstNumber, secondNumber, thirdNumber);

            
            Assert.AreEqual(expected, maxNumber);
        }
    }
}