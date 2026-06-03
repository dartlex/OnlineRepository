using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        Game game;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int timeLeft = 10;
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += QuizTimer_Tick;
        }

        private void QuizTimer_Tick(object? sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                TimeLiveLabel.Text = timeLeft.ToString();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Время истекло");
                game.AcceptAnswer(-9999);
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

        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            if (welcomeForm.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(welcomeForm.userNameTextBox.Text))
                {
                    var user = new User(welcomeForm.userNameTextBox.Text);
                    game = new Game(user);
                    ShowNextQuestion();
                }
                else
                {
                    MessageBox.Show("Введите корректное имя");
                    mainForm_Load(sender, e);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = game.GetQuestionNumberText();
            timeLeft = 10;
            TimeLiveLabel.Text = timeLeft.ToString();
            timer.Start();
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
                timer.Stop();
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
    }
}
