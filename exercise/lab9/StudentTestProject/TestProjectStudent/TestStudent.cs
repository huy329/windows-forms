using StudentServiceLib;

namespace TestProjectStudent
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void whenScore8_Letter_ShouldBeA()
        {
            Student s = new Student();
            s.Score = 8;

            char Letter = s.getLetterScore();
            Assert.AreEqual('A', Letter);
        }

        [TestMethod]
        public void whenScore10_Letter_ShouldBeA()
        {
            Student s = new Student();
            s.Score = 10;

            char Letter = s.getLetterScore();
            Assert.AreEqual('A', Letter);
        }
        [TestMethod]
        public void whenScore7Half_Letter_ShouldBeB()
        {
            Student s = new Student();
            s.Score = 7.5;

            char Letter = s.getLetterScore();
            Assert.AreEqual('B', Letter);
        }
        [TestMethod]
        public void whenScore7_Letter_ShouldBeB()
        {
            Student s = new Student();
            s.Score = 7;

            char Letter = s.getLetterScore();
            Assert.AreEqual('B', Letter);
        }

        [TestMethod]
        [DataRow(9.5,'A')]
        [DataRow(7.5,'B')]
        public void TestMultipleScore(double a , char expect) 
        {
            Student s = new Student();
            s.Score = a;

            char Letterscore = s.getLetterScore();
            Assert.AreEqual(Letterscore, expect);
        }

        [TestMethod]
        [DataRow(15, "Score must not exeed 10.0")]
        [DataRow(25, "Score must not exeed 10.0")]
        [DataRow(75, "Score must not exeed 10.0")]
        public void TestInputScore(double a, String expres)
        {
            Student s = new Student();
            s.Score = a;
            char LetterScore = s.getLetterScore();
            Assert.IsTrue(LetterScore > 10 , expres);

        }
        [TestMethod]
        public void whenPassingNull_AnException_ShouldBeThrow()
        {
            StudentService sv = new StudentService();
            Student s = null;
            bool hasException = false;
            try
            {
                sv.addStudent(s);
            }catch(NullReferenceException e)
            {
                hasException = true;
            }
            Assert.IsTrue(hasException);

        }

    }
}