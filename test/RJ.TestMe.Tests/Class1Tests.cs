using Xunit;

namespace RJ.TestMe
{
    public class Class1Tests
    {
        [Theory]
#if NET10_0
        [InlineData(1, 3)]
        [InlineData(2, 6)]
        [InlineData(3, 9)]
#else
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        [InlineData(3, 6)]
#endif
        public void TestCompilerSwitches_OnAttributes(int given, int expected)
        {
            // Act
            var actual = Class1.Multiply(given);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCompilerSwitches_OnCode()
        {
#if NET10_0
            Assert.Equal(3, Class1.Multiply(1));
#else
            Assert.Equal(2, Class1.Multiply(1));
#endif
        }

        [Fact]
        public void TestAdd()
        {
            // Arrange
            const int a = 5;
            const int b = 3;

            // Act
            var result = Class1.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestSubtract()
        {
            // Arrange
            const int a = 5;
            const int b = 3;

            // Act
            var result = Class1.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestDivide()
        {
            // Arrange
            const int a = 6;
            const int b = 3;

            // Act
            var result = Class1.Divide(a, b);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
