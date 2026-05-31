using System.IO.Enumeration;
using System.Text;

namespace GeniyIdiotConsoleApp
{
    public class DiagnoseCalculator
    {
        static string Calculate(int questionsCount, User user)
        {
            var diagnoses = new string[6];
            diagnoses[0] = "Кретин";
            diagnoses[1] = "Идиот";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";

            var userDiagnose = diagnoses[user.CountRightAnswers];

            return user.Name + " " + userDiagnose;
        }
    }
}


