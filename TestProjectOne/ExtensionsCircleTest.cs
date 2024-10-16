using System;
using Xunit;
using FluentAssertions;
using ProjectOne;

namespace TestProjectOne
{

    public class ExtensionsCircleTest
    {
        [Fact]
        public void Circumference_ShouldReturnCorrectValue_ForValidRadius()
        {
            double radius = 5.0;
            var circle = new Circle(radius);

            double circumference = circle.Circumference();

            double expected = 2 * Math.PI * radius;
            circumference.Should().BeApproximately(
                expected,
                0.0001, 
                "because the circumference is calculated using the formula 2 * pi * radius"
            );
        }

        [Fact]
        public void Circumference_ShouldThrowArgumentNullException_WhenCircleIsNull()
        {
            Circle circle = null;

            Action act = () => circle.Circumference();

            act.Should().Throw<ArgumentNullException>()
               .WithMessage("*circle*");
        }

        [Fact]
        public void Circumference_ShouldHandleZeroRadius()
        {
            double radius = 0.0;
            var circle = new Circle(radius);

            double circumference = circle.Circumference();

            circumference.Should().Be(
                0.0, 
                "because the circumference of a circle with a radius of zero should be zero"
            );
        }

        [Fact]
        public void Circumference_ShouldHandleLargeRadius()
        {
            double radius = 1_000_000.0;
            var circle = new Circle(radius);

            double circunferencia = circle.Circumference();

            double expected = 2 * Math.PI * radius;
            circunferencia.Should().BeApproximately(
                expected, 
                0.0001, 
                "Result: 2 * pi * radio"
            );
        }


        [Fact]
        public void Circumference_ShouldReturnCorrectValue_ForLargeRadius()
        {
            double radius = 1_000_000.0;
            var circle = new Circle(radius);

            double circumference = circle.Circumference();

            double expected = 2 * Math.PI * radius;
            circumference.Should().BeApproximately(
                expected, 
                0.0001, 
                "because the circumference is calculated using the formula 2 * pi * radius"
            );
        }
    }
}
