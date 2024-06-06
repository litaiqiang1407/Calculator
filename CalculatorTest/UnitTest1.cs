using Calculator;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Testing_Multiple_Two_Int_Number_Return_Int_Result()
        {
            var multiple = Mul.MultiplyTwoNumbers(5, 10.8);
            Assert.Equal(54, multiple);
        }
    }
}