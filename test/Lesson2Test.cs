using System;
using System.Collections.Generic;
using System.Linq;
using src;
using Xunit;

namespace test
{
    public class Lesson2Test
    {
        Lesson2 l2 = new Lesson2();

        [Fact]
        public void q1Test() => Assert.Equal(13, l2.q1(5, 6, 2));

        [Fact]
        public void q2Test() => Assert.Equal(5, l2.q2(2, 4, 6, 8));

        [Fact]
        public void q3Test() => Assert.Equal("Wow! You will be 24 soon!", l2.q3(23));

        [Fact]
        public void q4Test()
        {
            List<String> expected = new List<String>();
            expected.Add("30 30 30 30");
            expected.Add("30303030");
            
            List<String> actual = l2.q4(30);
            bool checker = expected.SequenceEqual(actual);

            Assert.True(checker, "Seems like the list is not equal, check if they are in order");

        }

        [Fact]
        public void q5Test()
        {
            Assert.Equal(13, l2.q1(5, 6, 2));
        }

        [Fact]
        public void q6Test()
        {
            Assert.Equal(13, l2.q1(5, 6, 2));
        }

        [Fact]        
        public void q7Test()
        {
            Assert.Equal(13, l2.q1(5, 6, 2));
        }

        [Fact]
        public void q8Test()
        {
            Assert.Equal(13, l2.q1(5, 6, 2));
        }
        
        [Fact]
        public void q9Test()
        {
            Assert.Equal(13, l2.q1(5, 6, 2));
        }
    }
}
