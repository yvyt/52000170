
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
        [TestMethod]
        public void Score3Point5_D()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Jonh";
            s.Age = 20;
            s.Score = 3.5;
            char c = s.getLetterScore();
            Assert.AreEqual('D', c);
        }
        [TestMethod]
        public void ScoreUnder3Point5_E()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Jonh";
            s.Age = 20;
            s.Score = 3;
            char c = s.getLetterScore();
            Assert.AreEqual('E', c);
        }

        [TestMethod]
        public void AddStudent_Success_True()
        {
            StudentService list = new StudentService();
            Student s = new Student() { Id = 1, Name = "Mart", Age = 20, Score = 8 };
            bool st = list.addStudent(s);
            Assert.IsTrue(st);
            


            int size=list.size();
            Assert.AreEqual(1, size);
        }
        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void inputValidScore()
        {
            
        }

    }
}