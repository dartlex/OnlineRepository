namespace WinFormsApp
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addQuestionLabel = new Label();
            addQuestionTextBox = new TextBox();
            addAnswerTextBox = new TextBox();
            addAnswerLabel = new Label();
            closeAddQuestionButton = new Button();
            SuspendLayout();
            // 
            // addQuestionLabel
            // 
            addQuestionLabel.AutoSize = true;
            addQuestionLabel.Location = new Point(102, 61);
            addQuestionLabel.Name = "addQuestionLabel";
            addQuestionLabel.Size = new Size(204, 25);
            addQuestionLabel.TabIndex = 0;
            addQuestionLabel.Text = "Напишите свой вопрос";
            // 
            // addQuestionTextBox
            // 
            addQuestionTextBox.Location = new Point(57, 89);
            addQuestionTextBox.Name = "addQuestionTextBox";
            addQuestionTextBox.Size = new Size(291, 31);
            addQuestionTextBox.TabIndex = 1;
            // 
            // addAnswerTextBox
            // 
            addAnswerTextBox.Location = new Point(57, 185);
            addAnswerTextBox.Name = "addAnswerTextBox";
            addAnswerTextBox.Size = new Size(291, 31);
            addAnswerTextBox.TabIndex = 3;
            // 
            // addAnswerLabel
            // 
            addAnswerLabel.AutoSize = true;
            addAnswerLabel.Location = new Point(91, 157);
            addAnswerLabel.Name = "addAnswerLabel";
            addAnswerLabel.Size = new Size(233, 25);
            addAnswerLabel.TabIndex = 2;
            addAnswerLabel.Text = "Напишите ответ на вопрос";
            // 
            // closeAddQuestionButton
            // 
            closeAddQuestionButton.Location = new Point(147, 253);
            closeAddQuestionButton.Name = "closeAddQuestionButton";
            closeAddQuestionButton.Size = new Size(112, 34);
            closeAddQuestionButton.TabIndex = 4;
            closeAddQuestionButton.Text = "Добавить";
            closeAddQuestionButton.UseVisualStyleBackColor = true;
            closeAddQuestionButton.Click += closeAddQuestionButton_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 311);
            Controls.Add(closeAddQuestionButton);
            Controls.Add(addAnswerTextBox);
            Controls.Add(addAnswerLabel);
            Controls.Add(addQuestionTextBox);
            Controls.Add(addQuestionLabel);
            Name = "AddQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новый вопрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addQuestionLabel;
        private Label addAnswerLabel;
        private Button closeAddQuestionButton;
        public TextBox addQuestionTextBox;
        public TextBox addAnswerTextBox;
    }
}