using System;
using Xunit;
using FluentAssertions;
using ProjectOne;


namespace TestProjectOne
{
    public class UnitTestSumEvenNumbers
    {
        [Fact]
        public void EvenNumbersSum_ShouldReturnZero_ForEmptyArray()
        {
            int[] numbers = Array.Empty<int>();

            int result = numbers.EvenNumbersSum();

            result.Should().Be(0);
        }

        [Fact]
        public void EvenNumbersSum_ShouldReturnSum_ForAllEvenNumbers()
        {
            int[] numbers = { 2, 4, 6, 8 };

            int result = numbers.EvenNumbersSum();

            result.Should().Be(20);
        }

        [Fact]
        public void EvenNumbersSum_ShouldReturnSum_ForMixedNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            int result = numbers.EvenNumbersSum();

            result.Should().Be(12);
        }

        [Fact]
        public void EvenNumbersSum_ShouldReturnZero_ForAllOddNumbers()
        {
            int[] numbers = { 1, 3, 5, 7 };

            int result = numbers.EvenNumbersSum();

            result.Should().Be(0);
        }

        [Fact]
        public void EvenNumbersSum_ShouldHandleLargeArrays_UsingParallelProcessing()
        {
            int size = 10_000;
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = i;
            }

            int result = numbers.EvenNumbersSum();
            result.Should().Be(24995000);
        }


        [Fact]
        public void EvenNumbersSum_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            int[] numbers = null;

            Action act = () => numbers.EvenNumbersSum();

            act.Should().Throw<ArgumentNullException>()
               .WithMessage("*source*");
        }

        [Fact]
        public void EvenNumbersSum_ShouldHandleNegativeNumbers()
        {
            int[] numbers = { -2, -1, 0, 1, 2 };

            int result = numbers.EvenNumbersSum();

            result.Should().Be(0);
        }
    }
}