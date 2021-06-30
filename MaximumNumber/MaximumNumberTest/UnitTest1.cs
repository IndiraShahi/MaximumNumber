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
        [Test]
        public void GivenFirstFloatNumberMax_WhenAct_ReturnFirstNumber()
        {

            float firstNumber = 5.6f;
            float secondNumber = 4.6f;
            float thirdNumber = 3.6f;
            float expected = 5.6f;

            float maxNumber = Max.MaxFloat(firstNumber, secondNumber, thirdNumber);


            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondFloatNumberMax_WhenAct_ReturnSecondNumber()
        {
            float firstNumber = 3.6f;
            float secondNumber = 5.6f;
            float thirdNumber = 4.6f;
            float expected = 5.6f;


            float maxNumber = Max.MaxFloat(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenThirdFloatNumberMax_WhenAct_ReturnThirdNumber()
        {

            float firstNumber = 3.6f;
            float secondNumber = 4.6f;
            float thirdNumber = 5.6f;
            float expected = 5.6f;
            float maxNumber = Max.MaxFloat(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expected, maxNumber);
        }
        [Test]
        public void GivenFirstStringWordMax_WhenAct_ReturnFirstWord()
        {
            // Arrange
            string firstWord = "Peach";
            string secondWord = "Apple";
            string thirdWord = "Banana";
            string expected = "Peach";

            // Act
            string maxString = Max.Maxstring(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }

        [Test]
        public void GivenSecondStringWordMax_WhenAct_ReturnSecondWord()
        {
            // Arrange
            string firstWord = "Apple";
            string secondWord = "Peach";
            string thirdWord = "Banana";
            string expected = "Peach";

            // Act
            string maxString = Max.Maxstring(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }

        [Test]
        public void GivenThirdStringWordMax_WhenAct_ReturnThirdWord()
        {
            // Arrange
            string firstWord = "Banana";
            string secondWord = "Apple";
            string thirdWord = "Peach";
            string expected = "Peach";

            // Act
            string maxString = Max.Maxstring(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }
    }
}

 