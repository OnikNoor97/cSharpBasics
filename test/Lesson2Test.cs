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
            List<int> expected = new List<int>();
            expected.Add(303);
            expected.Add(86);

            List<int> actual = l2.q5(30);
            bool checker = expected.SequenceEqual(actual);

            Assert.True(checker, "Seems like the list is not equal, check if they are in order");
        }

        [Fact]
        public void q6Test()
        {
            List<int> expected = new List<int>();
            expected.Add(7);
            expected.Add(8);
            expected.Add(9);
            expected.Add(10);
            expected.Add(11);
            expected.Add(12);
            expected.Add(13);
            expected.Add(14);
            expected.Add(15);
            expected.Add(16);

            List<int> actual = l2.q6(7,16);
            bool checker = expected.SequenceEqual(actual);

            Assert.True(checker, "Seems like the list is not equal, are you sure you are doing in the right range/order?");
        }

        [Fact]        
        public void q7Test()
        {
            List<int> expected = new List<int>();
            expected.Add(7);
            expected.Add(9);
            expected.Add(11);
            expected.Add(13);
            expected.Add(15);

            List<int> actual = l2.q7(7, 16);
            bool checker = expected.SequenceEqual(actual);

            Assert.True(checker, "Seems like the list is not equal, are you sure you are doing in the right range/order?");
        }

        [Fact]
        public void q8Test()
        {
            List<int> expected = new List<int>();
            expected.Add(8);
            expected.Add(10);
            expected.Add(12);
            expected.Add(14);
            expected.Add(16);

            List<int> actual = l2.q8(7, 16);
            bool checker = expected.SequenceEqual(actual);

            Assert.True(checker, "Seems like the list is not equal, are you sure you are doing in the right range/order?");
        }
        
        [Fact]
        public void q9Test()
        {
            List<int> expected = new List<int>();
            expected.Add(7);
            expected.Add(11);
            expected.Add(13);

            List<int> actual = l2.q9(7, 16);
            bool checker = expected.SequenceEqual(actual);

            Assert.True(checker, "Seems like the list is not equal, are you sure you are doing in the right range/order?");
        }
    }
}
