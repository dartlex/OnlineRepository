namespace WinFormsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(171, 474);
            nextButton.Margin = new Padding(4, 4, 4, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(320, 99);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI", 16.2F);
            questionNumberLabel.Location = new Point(29, 41);
            questionNumberLabel.Margin = new Padding(4, 0, 4, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(194, 45);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionTextLabel.Location = new Point(29, 162);
            questionTextLabel.Margin = new Padding(4, 0, 4, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(172, 32);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            questionTextLabel.Click += questionTextLabel_Click;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Font = new Font("Segoe UI", 16.2F);
            userAnswerTextBox.Location = new Point(29, 325);
            userAnswerTextBox.Margin = new Padding(4, 4, 4, 4);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(319, 51);
            userAnswerTextBox.TabIndex = 3;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 614);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "mainForm";
            Text = "Гений-Идиот";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
    }
}
