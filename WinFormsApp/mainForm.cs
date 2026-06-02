using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        Game game;
        public MainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            var user = new User(welcomeForm.userNameTextBox.Text);
            game = new Game(user); 
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                game.AcceptAnswer(userAnswer);
                if (game.End())
                {
                    var message = game.CalculateDiagnose();
                    MessageBox.Show(message);
                    return;
                }
                userAnswerTextBox.Text = string.Empty;
                ShowNextQuestion();
            }
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
