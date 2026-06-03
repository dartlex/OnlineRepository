using System.IO.Enumeration;
using System.Text;

namespace ClassLibrary
{
    public class DiagnoseCalculator
    {
        public static string Calculate(int countQuestions, User user)
        {
            var diagnoses = GetDiagnoses();

            var percentRightAnswers = user.CountRightAnswers * 100 / countQuestions;

            return diagnoses[percentRightAnswers / 20];
        } 
        public static string[] GetDiagnoses()
        {
            var diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            return diagnoses;
        }
    }
}


