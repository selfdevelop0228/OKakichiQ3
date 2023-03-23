using ScoreManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagement
{
    public  class MarkCalculator
    {
        public MarkCalculator()
        {
            
        }
        
        public Score GetResult (int scores)
        {
            Score score = new Score()
            {
                ScoreMark = scores,
                Grade = GetGradeInternalRule(scores),
                Message= GetMessageInternalRule(scores)
            };

            return score;
        }
        //public List<Score> GetResult(List<int> scores)
        //{
        //    List<Score> result = new List<Score>();

        //    foreach (var data in scores)
        //    {
        //        result.Add(new Score()
        //        {
        //            ScoreMark = data,
        //            Grade = "grade is " + GetGradeInternalRule(data),
        //            Message = GetMessageInternalRule(data)
        //        });
        //        //Console.WriteLine("The student score is {0} grade is {1} message is {2} ", data, GetGradeInternalRule (data), GetMessageInternalRule(data));
        //    }

        //    return result;
        //}

        private string GetGradeInternalRule(int score)
        {
            if (score < 0 || score > 100)
            {
                return "enter no between 0 - 100";
            }
            string result = "";
            if (score >= 80)
            {
                result = "A";
            }
            else if (score > 75 && score < 80)
            {
                result = "B";
            }
            else if (score > 45 && score <= 75)
            {
                result = "C";
            }
            else if (score > 30 && score <= 45)
            {
                result = "D";
            }
            else
            {
                result = "E";

            }
            return result;
        }

        private string GetMessageInternalRule(int score)
        {
            if (score < 0 || score > 100)
            {
                return "enter no between 0 - 100";
            }
            string result = "";
            if (score >= 80)
            {
                result = "Good job!";
            }
            else if (score > 75 && score < 80)
            {
                result = "Keep it up!";
            }
            else if (score > 45 && score <= 75)
            {
                result = "You almost there!";
            }
            else if (score > 30 && score <= 45)
            {
                result = "Pratice more";
            }
            else
            {
                result = "You can do it";

            }
            return result;
        }
    }
}
