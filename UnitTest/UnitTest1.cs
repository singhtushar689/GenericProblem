using GenericProblem;

namespace UnitTest
{
    public class Tests
    {
        FindMaxGeneric<int> genericsMethodForInt = new FindMaxGeneric<int>();
        FindMaxGeneric<double> genericsMethodForFloat = new FindMaxGeneric<double>();
        FindMaxGeneric<string> genericsMethodForString = new FindMaxGeneric<string>();


        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldreturnFirstMax()
        {
            string result = genericsMethodForString.Max("Tushar","Ritesh","Sachin");
            Assert.AreEqual("Tushar", result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldreturnSecondMax()
        {
            string result = genericsMethodForString.Max("lop", "ryt", "lkj");
            Assert.AreEqual("ryt", result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldreturnThirdMax()
        {
            string result = genericsMethodForString.Max("lop", "aer", "ryt");
            Assert.AreEqual("ryt", result);
        }
    }
}