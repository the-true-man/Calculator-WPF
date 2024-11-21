using simpleCalculator;

namespace SimpleCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void testSumTwoPositiveNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = 10;
            double expectedResult = 15;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Sum(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testSumZero()
        {
            //arrange - подготовка данных для теста
            double num1 = 0;
            double num2 = 0;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Sum(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testSumTwoNegativeNum()
        {
            //arrange - подготовка данных для теста
            double num1 = -5;
            double num2 = -10;
            double expectedResult = -15;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Sum(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testSumNegativeNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = -10;
            double expectedResult = -5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Sum(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testSumMaxMin()
        {
            //arrange - подготовка данных для теста
            double num1 = double.MaxValue;
            double num2 = double.MinValue;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Sum(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testMinus()
        {
            //arrange - подготовка данных для теста
            double num1 = 10;
            double num2 =5;
            double expectedResult = 5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Minus(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testMinusNegativNumber()
        {
            //arrange - подготовка данных для теста
            double num1 = -5;
            double num2 = -10;
            double expectedResult = 5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Minus(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testMinusZero()
        {
            //arrange - подготовка данных для теста
            double num1 = 0;
            double num2 = 0;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Minus(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testMinusPositiveAndNegativeNums()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = -10;
            double expectedResult = 15;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Minus(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testMinusMinMax()
        {
            //arrange - подготовка данных для теста
            double num1 = double.MaxValue;
            double num2 = double.MinValue;
            double expectedResult = double.PositiveInfinity;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Minus(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }


        [Test]
        public void testMultiplyPositiveNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = 10;
            double expectedResult = 50;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Multiply(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testMultiplyNegativeNum()
        {
            //arrange - подготовка данных для теста
            double num1 = -5;
            double num2 = -10;
            double expectedResult = 50;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Multiply(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testMultiplyWithZero()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = 0;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Multiply(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testMultiplyWithNegariveNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = -10;
            double expectedResult = -50;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Multiply(num1, num2);
            //Assert - проверка фактического результата ожидаемому
         
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testMultiplyMaxMin()
        {
            //arrange - подготовка данных для теста
            double num1 = double.MaxValue;
            double num2 = double.MinValue;
            double expectedResult = double.NegativeInfinity;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Multiply(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testDivPositiveNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 10;
            double num2 = 5;
            double expectedResult = 2;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testDivNegativeNum()
        {
            //arrange - подготовка данных для теста
            double num1 = -10;
            double num2 = -5;
            double expectedResult = 2;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testDivNumWithZero()
        {
            //arrange - подготовка данных для теста
            double num1 = 0;
            double num2 = 5;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testDivNumWithNegativeNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 10;
            double num2 = -5;
            double expectedResult = -2;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testDivMinMax()
        {
            //arrange - подготовка данных для теста
            double num1 = double.MaxValue;
            double num2 = double.MinValue;
            double expectedResult = -1;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testDivByZero()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = 0;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testEquallyPosNum()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double expectedResult = 5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Equally(num1);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testEquallyNegNum()
        {
            //arrange - подготовка данных для теста
            double num1 = -5;
            double expectedResult = -5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Equally(num1);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testEquallyZero()
        {
            //arrange - подготовка данных для теста
            double num1 = 0;
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Equally(num1);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testClearPosNum()
        {
            //arrange - подготовка данных для теста
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Clear();
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testClearNegNum()
        {
            //arrange - подготовка данных для теста
            
            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Clear();
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testClearZero()
        {
            //arrange - подготовка данных для теста

            double expectedResult = 0;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Clear();
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void testSumDrob()
        {
            //arrange - подготовка данных для теста
            double num1 = 2.5;
            double num2 = 3.5;
            double expectedResult = 6;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Sum(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testMinusDrob()
        {
            //arrange - подготовка данных для теста
            double num1 = 5.5;
            double num2 = 2.5;
            double expectedResult = 3;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Minus(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testMultiplyDrob()
        {
            //arrange - подготовка данных для теста
            double num1 = 2.5;
            double num2 = 2.0;
            double expectedResult = 5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Multiply(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void testDivDrob()
        {
            //arrange - подготовка данных для теста
            double num1 = 5;
            double num2 = 2;
            double expectedResult = 2.5;

            //Act - вызов тетсируемого метода
            double factResult = Calculator.Div(num1, num2);
            //Assert - проверка фактического результата ожидаемому
            Assert.That(factResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void test()
        {
            double num1 = -10;
            double num2 = -5;
            double eResult = 2;

            double fResult = Calc2.div(num1, num2);

            Assert.That(fResult, Is.EqualTo(eResult));
        }

        [Test]
        public void test2()
        {
            double num1 = 0;
            double eResult = 0;

            double fResult = Calc2.Equally(num1);

            Assert.That(fResult, Is.EqualTo(eResult));
        }

        [Test]
        public void test3()
        {
            double eResult = 0;

            double fResult = Calc2.Clear();

            Assert.That(fResult, Is.EqualTo(eResult));
        }

    }
}