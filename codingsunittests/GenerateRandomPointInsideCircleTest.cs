using NUnit.Framework;

using static interviewcodings2018.GenerateRandomPointInsideCircle;

namespace codingsunittests
{
    [TestFixture]
    public class GenerateRandomPointInsideCircleTest
    {
        [Test]
        public void PointIsInsideCircle_CenterAtOrigin_Success()
        {
            int centerX = 0;
            int centerY = 0;
            int radius = 10;
            PointXY pointXY = GetPointInsideCircle(centerX, centerY, radius);
            Assert.IsTrue(pointXY.x > -radius && pointXY.x < radius);
            Assert.IsTrue(pointXY.y > -radius && pointXY.y < radius);
        }

        [Test]
        public void PointIsInsideCircle_PositivieCenter_Success()
        {
            int centerX = 10;
            int centerY = 10;
            int radius = 10;
            PointXY pointXY = GetPointInsideCircle(centerX, centerY, radius);
            Assert.IsTrue(pointXY.x > centerX - radius && pointXY.x < centerX + radius);
            Assert.IsTrue(pointXY.y > centerY - radius && pointXY.y < centerY + radius);
        }

        [Test]
        public void PointIsInsideCircle_NegativeCenter_Success()
        {
            int centerX = -10;
            int centerY = -10;
            int radius = 20;
            PointXY pointXY = GetPointInsideCircle(centerX, centerY, radius);
            Assert.IsTrue(pointXY.x > centerX - radius && pointXY.x < centerX + radius);
            Assert.IsTrue(pointXY.y > centerY - radius && pointXY.y < centerY + radius);
        }

        [Test]
        public void PointIsInsideCircle_RandomCenter_Success()
        {
            int centerX = -10;
            int centerY = 200;
            int radius = 2000;
            PointXY pointXY = GetPointInsideCircle(centerX, centerY, radius);
            Assert.IsTrue(pointXY.x > centerX - radius && pointXY.x < centerX + radius);
            Assert.IsTrue(pointXY.y > centerY - radius && pointXY.y < centerY + radius);
        }
    }
}
