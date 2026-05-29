namespace OnlineRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем списки вопросов и ответов
            string[] questions = new string[5];
            questions[0] = "Сколько будет 2 плюс 2, умноженное на 2?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько надо сделать распилов?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут для трех уколов?";
            questions[4] = "5 свечей горело, 2 потухли. Сколько свечей осталось?";

            int[] answers = new int[5];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;

            // 2. Счетчик правильных ответов
            int correctAnswersCount = 0;

            // 3. Цикл опроса
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(questions[i]);           // а) Выводим вопрос

                Console.Write("Ваш ответ: ");              // б) Запрашиваем ответ
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == answers[i])              // в) Сравниваем
                {
                    correctAnswersCount++;                 // г) Увеличиваем счетчик
                }
            }

            // 4. Вывод результата
            Console.WriteLine();
            Console.WriteLine($"Количество правильных ответов: {correctAnswersCount}");
        }
    }
}
