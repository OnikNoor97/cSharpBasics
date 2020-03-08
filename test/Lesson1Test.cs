using System;
using src;
using Xunit;

namespace test
{
    public class Lesson1Test
    {
        Lesson1 l1 = new Lesson1();
        [Fact]
        public void addTest() => Assert.Equal(9, l1.add(3, 6));

        [Fact]
        public void subtractTest() => Assert.Equal(4, l1.subtract(5, 1));

        [Fact]
        public void multiplyTest() => Assert.Equal(10, l1.multiply(5, 2));

        [Fact]
        public void divideTest() => Assert.Equal(5, l1.divide(10, 2));

    }
}
