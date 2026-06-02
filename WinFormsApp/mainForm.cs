using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestions;
        private int questionNumber;
        private User user;
        public MainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            user = new User(welcomeForm.userNameTextBox.Text);
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
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
                user.Diagnose = diagnose;
                UserResultStorage.Save(user);
                MessageBox.Show($"{user.Name}, Ваш диагноз {diagnose}");
                return;
            }
            userAnswerTextBox.Text = string.Empty;
            ShowNextQuestion();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void показатьПредыдущиеРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultForm();
            resultsForm.ShowDialog();
        }
    }
}
