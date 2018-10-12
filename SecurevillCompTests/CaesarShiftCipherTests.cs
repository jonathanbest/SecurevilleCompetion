using SecurevilleComp;
using System;
using Xunit;
using FluentAssertions;

namespace SecurevilleCompTests
{
    public class CaesarShiftCipherTests
    {
        public class ConvertChar
        {
            [Theory]
            [InlineData('A', 'X', -3)]
            [InlineData('B', 'Y', -3)]
            [InlineData('C', 'Z', -3)]
            [InlineData('Z', 'W', -3)]
            [InlineData('a', 'a', -3)]
            [InlineData('!', '!', -3)]
            [InlineData('Z', 'C', 3)]
            [InlineData(' ', ' ', 10)]
            public void Text_InputChar_ReturnChar(char input, char expected, int offset)
            {
                var conv = new CaesarShiftCipher
                    {OffSet = offset};

                var result = conv.ConvertChar(input);

                expected.Should().Be(result);
            }

            [Fact]
            public void Test1()
            {
                string expected = null;

                var test = new MyClass();
                var result = test.Convert("nathan");

                expected?.Should().Be("nathan");

            }

            class MyClass
            {
                public string Convert(string input)
                {
                    return null;
                }
            }

        }
    }
}
