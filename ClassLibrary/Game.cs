using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Game
    {
        User user;
        List<Question> questions;
        Question currentQuestion;
        int countQuestions;
        int questionNumber;
        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;

        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];

            questionNumber++;

            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }

            questions.Remove(currentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return "Вопрос №" + questionNumber;
        }
        
        public bool End()
        {
            return questions.Count == 0;
        }

        public string CalculateDiagnose()
        {
            var diagnose = DiagnoseCalculator.Calculate(countQuestions, user);
            user.Diagnose = diagnose;
            UserResultStorage.Append(user);

            return user.Name + ", Ваш диагноз: " + user.Diagnose;
        }
    }
}
