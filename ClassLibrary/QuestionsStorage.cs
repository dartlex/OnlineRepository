using Newtonsoft.Json;

namespace ClassLibrary
{
    public class QuestionsStorage
    {
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            var path = "questions.json";


            if (FileProvider.Exists(path))
            {
                var value = FileProvider.GetValue(path);
                
                questions = JsonConvert.DeserializeObject<List<Question>>(value) ?? questions;
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                SaveQuestions(questions);
            }
            return questions;
        }

        private static void SaveQuestions(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace("questions.json", jsonData);
        }

        public static void Add(Question newQuestion)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
            var value = JsonConvert.SerializeObject<List<Question>>();
            FileProvider.Append("questions.txt", value);
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == removeQuestion.Text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            FileProvider.Clear("questions.txt");
            SaveQuestions(questions);
        }
    }
}


