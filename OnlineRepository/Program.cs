using System.Text;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Здравствуйте! Как вас зовут?");
                var userName = Console.ReadLine();
                var user = new User(userName);

                var questions = QuestionsStorage.GetAll();
                var questionsCount = questions.Count;

                var random = new Random();

                for (int i = 0; i < questionsCount; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));
                    var randomQuestionIndex = random.Next(0, questions.Count);
                    Console.WriteLine(questions[randomQuestionIndex].Text);
                    var userAnswer = GetNumber();

                    var rightAnswer = questions[randomQuestionIndex].Answer;

                    if (userAnswer == rightAnswer)
                    {
                        user.AcceptRightAnswer();
                    }

                    questions.RemoveAt(randomQuestionIndex);
                }

                Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);

                var diagnose = CalculateDiagnose(questionsCount, user.CountRightAnswers);
                user.Diagnose = diagnose;

                Console.WriteLine($"{userName}, Ваш диагноз:" + diagnose);

                UserResultStorage.Save(user);

                var userChoise = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");
                if (userChoise)
                {
                    ShowUserResults();
                }

                userChoise = GetUserChoice("Хотите добавить новый вопрос?");
                if (userChoise)
                {
                    AddNewQuestion();
                }

                userChoise = GetUserChoice("Хотите удалить существующй вопрос?");
                if (userChoise)
                {
                    RemoveQuestion();
                }

                userChoise = GetUserChoice("Хотите начать сначала?");
                if (!userChoise)
                {
                    break;
                }
            }
        }

        static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер вопроса, который хотите удалить");
            var questions = QuestionsStorage.GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }
            var removeQuestionNumber = GetNumber();
            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = GetNumber();
            }
            var removeQuestion = questions[removeQuestionNumber - 1];
            QuestionsStorage.Remove(removeQuestion);
        }

        static void AddNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответа на вопрос");
            var answer = GetNumber();

            var newQuestion = new Question(text, answer);
            QuestionsStorage.Add(newQuestion);
        }

        private static void ShowUserResults()
        {
            var result = UserResultStorage.GetUserResults();
            Console.WriteLine("{0,-20} {1,18} {2,15}", "Имя", "Кол-во правильных ответов", "Диагноз");
            foreach (var user in result)
            {
                Console.WriteLine("{0,-20}{1,18}{2,15}", user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }

        

        

        static string CalculateDiagnose(int questionsCount, int correctAnswersCount)
        {
            var diagnoses = GetDiagnoses();

            var percentRightAnswers = correctAnswersCount * 100 / questionsCount;

            return diagnoses[percentRightAnswers / 20];
        }

        private static int GetNumber()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Введите число");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введите число от -2*10^9 до 2*10^9");
                }
            }
        }

        static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.WriteLine($"{message} Введите Да или Нет");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "нет")
                {
                    return false;
                }
                if (userInput.ToLower() == "да")
                {
                    return true;
                }
            }
        }
        static string[] GetDiagnoses()
        {
            var diagnoses = new string[6];
            diagnoses[0] = "Кретин";
            diagnoses[1] = "Идиот";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            return diagnoses;
        }
    }
}


