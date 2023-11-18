namespace ShapeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = Shape.Shape.FindArea(Math.PI);
            Assert.Equal(Math.Pow(Math.PI, 3), result);
        }

        [Fact]
        public void Test2()
        {
            var result = Shape.Shape.FindArea(-11);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test3()
        {
            var result = Shape.Shape.FindArea(1, 5.7, -7);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test4()
        {
            var result = Shape.Shape.FindArea(1, 5.7, 64.7);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test5()
        {
            var result = Shape.Shape.FindArea(1, 5.7, 4.8);
            Assert.Equal(1.1390099867867689, result);
        }

        [Fact]
        public void Test6()
        {
            var result = Shape.Shape.IsRightTriangle(1, 5.7, 4.8);
            Assert.Equal(false, result);
        }

        [Fact]
        public void Test7()
        {
            var result = Shape.Shape.IsRightTriangle(-1, 5.7, 4.8);
            Assert.Equal(false, result);
        }

        [Fact]
        public void Test8()
        {
            var result = Shape.Shape.IsRightTriangle(3, 4, 5);
            Assert.Equal(true, result);
        }
    }
}