using GradesChecker;


//Get percentage
var gradeCalculator = new GradeCheck();
Console.WriteLine("Give your percentage");

var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGrade(percentage);   

Console.WriteLine($"Grade is : {grade}");

