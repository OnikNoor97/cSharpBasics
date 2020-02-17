using src;
using Xunit;

namespace test
{
    public class Lesson3Test
    {
        Lesson3 l3 = new Lesson3();

        [Fact]
        public void q1Test()
        {
            Assert.Equal("Hello there", l3.q1("Hello", "there"));
        }

        [Fact]
        public void q2Test()
        {
            Assert.Equal("Alright", l3.q2("Alright  "));
        }

        [Fact]
        public void q3Test()
        {
            Assert.Equal(11, l3.q3("Hello There"));
        }

        [Fact]
        public void q4Test()
        {
            Assert.Equal(true, l3.q4("Molly"));
        }

        [Fact]
        public void q5Test()
        {
            Assert.Equal(4, l3.q5("This is a test"));
        }

        [Fact]
        public void q6Test()
        {
            Assert.Equal("this", l3.q6("THIS"));
        }

        [Fact]
        public void q7Test()
        {
            Assert.Equal("HELLOTHERE", l3.q7("hellothere"));
        }

        [Fact]
        public void q8Test()
        {
            Assert.Equal("gomethins", l3.q8("something"));
        }

        [Fact]
        public void q9Test()
        {
            Assert.Equal("htrae no tahW", l3.q9("What on earth"));
        }

    }
}