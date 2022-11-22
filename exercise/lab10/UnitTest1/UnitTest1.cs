using UnitTestConsole;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, "Huy", 1, true, 4, 5842.875)]
        [DataRow(2, "Kirasuo", 1, true, 5, 6843.875)]
        [DataRow(3, "Mai Weeboo", 1, false, 6, 7862.5)]
        [DataRow(4, "Jokerisa", 1, true, 7, 8843.875)]
        public void TestTeacherSalary(int id, String name, double factor, bool Communism, int senior, double expect)
        {
            Teacher teacher1 = new Teacher();
            teacher1.ID = id;
            teacher1.Name = name;
            teacher1.Factor = factor;
            teacher1.UnionMember = Communism;
            teacher1.Seniority = senior;

            Assert.AreEqual(expect, teacher1.GetSalary());
        }

        [TestMethod]
        [DataRow(1, "Huy", true, 5, 2, 401490)]
        [DataRow(2, "Kirasuo", true, 6, 3)]
        [DataRow(3, "Mai Weeboo", 1, false, 4, 1)]
        [DataRow(4, "Jokerisa", 1, true, 7, 2)]

        public void TestResearcherSalary(int id, String name, bool Communism, int senior, int numbersofPaper, int Rank, double expect)
        {
            Researcher researcher = new Researcher();
            researcher.ID = id;
            researcher.Name = name;
            researcher.UnionMember = Communism;

            if (researcher.UnionMember == true)
            {
                researcher.Factor = 0.99;
            }
            else researcher.Factor = 1;
            researcher.NumOfPaper = numbersofPaper;
            researcher.PaperRank = Rank;

            Assert.AreEqual(expect, researcher.GetSalary());
        }
    }
}