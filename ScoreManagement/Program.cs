// See https://aka.ms/new-console-template for more information

using ScoreManagement;
using ScoreManagement.Model;

MarkCalculator markCalculator = new MarkCalculator();

List<Score> result = new List<Score>();
for (int i = 0; i < 5; i++)
{

    Console.WriteLine("Enter the score");
    int score =  Convert.ToInt32(Console.ReadLine());
    result.Add(markCalculator.GetResult(score));
}

 foreach(var data in result)
{
    Console.WriteLine("The student score is {0 } grade is {1} message is {2}", data.ScoreMark, data.Grade , data.Message);
}


Console.ReadLine();
