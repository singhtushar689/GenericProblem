using GenericProblem;

namespace UnitTest
{
    public class Tests
    {
        FindMaxGeneric<int> genericsMethodForInt = new FindMaxGeneric<int>();
        FindMaxGeneric<double> genericsMethodForFloat = new FindMaxGeneric<double>();
        FindMaxGeneric<string> genricsMethodFoeSrring = new FindMaxGeneric<string>();


        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldreturnFirstMax()
        {
            int result = genericsMethodForInt.Max(20, 10, 17);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldreturnSecondMax()
        {
            int result = genericsMethodForInt.Max(10, 20, 17);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldreturnThirdMax()
        {
            int result = genericsMethodForInt.Max(13, 27, 43);
            Assert.AreEqual(43, result);
        }
    }
}