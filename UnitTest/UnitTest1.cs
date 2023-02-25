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
            double result = genericsMethodForFloat.Max(20.7f, 10.4f, 17.9f);
            Assert.AreEqual(20.7f, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldreturnSecondMax()
        {
            double result = genericsMethodForFloat.Max(10.4f, 20.7f, 17.9f);
            Assert.AreEqual(20.7f, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldreturnThirdMax()
        {
            double result = genericsMethodForFloat.Max(10.4f, 17.9f, 20.7f);
            Assert.AreEqual(20.7f, result);
        }
    }
}