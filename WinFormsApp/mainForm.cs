using GeniyIdiotConsoleApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp
{
    public partial class mainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestions;
        private int questionNumber;
        private User user;
        public mainForm()
        {
            InitializeComponent();
        }

        private void questionTextLabel_Click(object sender, EventArgs e)
        {


        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
            user = new User("Неизвестно");
            questionNumber = 0;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            questionTextLabel.Text = currentQuestion.Text;
            questionNumber++;
            questionNumberLabel.Text = "Вопрос №" + questionNumber;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }

            questions.Remove(currentQuestion);
            var endGame = questions.Count == 0;
            if (endGame)
            {
                var diagnose = DiagnoseCalculator.Calculate(countQuestions, user);
                MessageBox.Show(diagnose);
                return;
            }

            ShowNextQuestion();
        }
    }
}
