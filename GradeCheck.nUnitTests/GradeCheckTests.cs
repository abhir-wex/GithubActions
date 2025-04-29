using GradesChecker;

namespace GradeCheck.nUnitTests
{
    public class GradeCheckTests
    {
        private GradesChecker.GradeCheck gradeCalculator;

        [SetUp]
        public void Setup()
        {
            gradeCalculator = new GradesChecker.GradeCheck();
        }

        [Test]
        public void GradePercentage_EqualTest()
        {
            //Assign
            var percentage = 85;

            //Act
            var grade = gradeCalculator.GetGrade(percentage);

            //Assert
            Assert.AreEqual("B", grade);
        }

        [Test]
        public void GradePercentage_NotEqualTest()
        {
            //Assign
            var percentage = 70;

            //Act
            var grade = gradeCalculator.GetGrade(percentage);

            //Assert
            Assert.AreNotEqual("B", grade);
        }
    }
}