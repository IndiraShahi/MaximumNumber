using MaximumNumber;
using NUnit.Framework;


namespace MaximumNumberTest
{
    public class Tests
    {
        MaxNumber Max = new MaxNumber();

        [Test]
        public void GivenFirstNumberMax_WhenAct_ReturnFirstNumber()
        {
            // Arrange
            int firstNumber = 15;
            int secondNumber = 5;
            int thirdNumber = 10;
            int expected = 15;

            // Act
            int maxNumber = Max.Max<int>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondNumberMax_WhenAct_ReturnSecondNumber()
        {
            // Arrange
            int firstNumber = 54;
            int secondNumber = 62;
            int thirdNumber = 43;
            int expected = 62;

            // Act
            int maxNumber = Max.Max<int>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenThirdNumberMax_WhenAct_ReturnThirdNumber()
        {
            // Arrange
            int firstNumber = 50;
            int secondNumber = 60;
            int thirdNumber = 90;
            int expected = 90;

            // Act
            int maxNumber = Max.Max<int>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenFirstFloatNumberMax_WhenAct_ReturnFirstNumber()
        {
            // Arrange
            float firstNumber = 35.1f;
            float secondNumber = 22.4f;
            float thirdNumber = 31.9f;
            float expected = 35.1f;

            // Act
            float maxNumber = Max.Max<float>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenSecondFloatNumberMax_WhenAct_ReturnSecondNumber()
        {
            // Arrange
            float firstNumber = 22.4f;
            float secondNumber = 35.1f;
            float thirdNumber = 31.9f;
            float expected = 35.1f;

            // Act
            float maxNumber = Max.Max<float>(firstNumber, secondNumber, thirdNumber);

            // Assert
            Assert.AreEqual(expected, maxNumber);
        }

        [Test]
        public void GivenThirdFloatNumberMax_WhenAct_ReturnThirdNumber()
        {
            // Arrange
            float firstNumber = 31.9f;
            float secondNumber = 22.4f;
            float thirdNumber = 35.1f;
            float expected = 35.1f;

            // Act
            float maxNumber = Max.Max<float>(firstNumber, secondNumber, thirdNumber);

            // Assert
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
            string maxString = Max.Max<string>(firstWord, secondWord, thirdWord);

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
            string maxString = Max.Max<string>(firstWord, secondWord, thirdWord);

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
            string maxString = Max.Max<string>(firstWord, secondWord, thirdWord);

            // Assert
            Assert.AreEqual(expected, maxString);
        }
    }
}

 