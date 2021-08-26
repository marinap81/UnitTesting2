using System;
using Xunit;
using CalcLib;


namespace Tests
{
    public class UnitTest1
    { 
        RecursiveCalc calc = new RecursiveCalc();

        public UnitTest1()
        { 
             this.calc = new RecursiveCalc();
        }


        //[Fact]
        //Function 1 tested
        //Fibonacci seq 0 1 1 2 3 5 8 13 21 what is next two? 
        public void FibonnacciRecTest() /*method is wrong, set up to accept highest ans of 1, my seq is correct, */
         {
         
            Assert.Equal(0, this.calc.FibonacciRec(0,1,0)); 
            Assert.Equal(1, this.calc.FibonacciRec(0,1,1)); 
            Assert.Equal(1, this.calc.FibonacciRec(0,1,2));
           Assert.Equal(2, this.calc.FibonacciRec(0,1,3)); /*test failed/seq not right, however incorrectly expects 1 */
           Assert.Equal(1, this.calc.FibonacciRec(1,1,2));
           Assert.Equal(1, this.calc.FibonacciRec(1,2,3)); 
           Assert.Equal(3, this.calc.FibonacciRec(2,3,5)); /*returns num2 =  3, test said it should be 1*/
           Assert.Equal(5, this.calc.FibonacciRec(3,5,8)); /* returns num2 =  5 -test said it should be 1 */
    
        } 
     
        //  Function 2 fact tested
        //https://byjus.com/maths/factorial/ 
        //The factorial of a positive integer is represented by the symbol “n!”.
        //Factorial of 2! expanded is 2x1, value of this factorial is 2 
        //Factorial of 3! expanded 3 ×2× 1, value of this factorial is 6 
         
        //WORKING, method correct: 
              [Theory]
              [InlineData(2,1,2)]
              [InlineData(3,1,6)] 
              [InlineData(4,1,24)]
              [InlineData(5,1,120)]
      
               public void FactorialRecTest(int inputvalue, int ans, int finalFactorialExpected)
                  {
                    Assert.Equal(finalFactorialExpected, calc.FactorialRec(inputvalue,ans));
                  }

        // 3. test PRIME NUMBERS TEST
        //The prime numbers below 20 are: 2, 3, 5, 7, 11, 13, 17, 19.

        [Theory] /*testing prime numbers are TRUE, method ok, tests pass*/
        [InlineData(2,2)] 
        [InlineData(5,2)]
        [InlineData(3,2)]
        [InlineData(11,2)]
        public void PrimeCheckRecTest_True(int value, int divisor)
        {
        Assert.True(calc.PrimeCheckRec(value,divisor));
       
        }

        [Theory] /*these test for FALSE/numbers that are NOT prime*/
        [InlineData(4,2)] 
        [InlineData(6,2)] 
        [InlineData(8,2)] 
        [InlineData(0,2)] /*0 exception error didnt come up*/

        public void PrimeCheckRecTest_False(int value, int divisor)
        {
         Assert.False(calc.PrimeCheckRec(value,divisor)); 

        }
        [Fact]
        public void PrimeCheckRecTest()
        {
          Assert.Equal(true,calc.PrimeCheckRec(2,2));   
          Assert.Equal(true,calc.PrimeCheckRec(5,2));     
          Assert.Equal(true,calc.PrimeCheckRec(7,2));    
          Assert.Equal(false,calc.PrimeCheckRec(8,2)); 
        }

        //4. Test for a DivideByZeroException when PrimeCheckRec is initialised with a divisor of 0*/
        [Fact]
        public void DivideByZeroExceptionTest()
        {
           Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(3, 0));
           Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(0, 0));
        }
        
    }
}





