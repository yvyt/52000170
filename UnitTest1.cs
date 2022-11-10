
using NuGet.Frameworks;
using StudentServiceLib;
using System.Globalization;

namespace StudentTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_A()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Jonh";
            s.Age = 20;
            s.Score = 8;
            char c = s.getLetterScore();
            Assert.AreEqual('A', c);
        }


        [TestMethod]
        public void Score7Points5_B()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Jonh";
            s.Age = 20;
            s.Score = 7.5;
            char c = s.getLetterScore();
            Assert.AreEqual('B', c);
        }
        [TestMethod]
        public void Score7_B()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Jonh";
            s.Age = 20;
            s.Score = 7;
            char c = s.getLetterScore();
            Assert.AreEqual('B', c);
        }
        [TestMethod]
        public void Score6_C()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Jonh";
            s.Age = 20;
            s.Score = 6;
            char c = s.getLetterScore();
            Assert.AreEqual('C', c);
        }
    }
}