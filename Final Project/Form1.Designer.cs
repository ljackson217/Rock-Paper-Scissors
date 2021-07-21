
namespace Final_Project
{
    partial class rockPaperScissorsForm
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
            this.compChoiceLabel = new System.Windows.Forms.Label();
            this.computerChoice = new System.Windows.Forms.Label();
            this.yourChoiceLabel = new System.Windows.Forms.Label();
            this.yourChoice = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.yourScoreOutput = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreOutput = new System.Windows.Forms.Label();
            this.makeSelectionLabel = new System.Windows.Forms.Label();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compChoiceLabel
            // 
            this.compChoiceLabel.AutoSize = true;
            this.compChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compChoiceLabel.Location = new System.Drawing.Point(165, 94);
            this.compChoiceLabel.Name = "compChoiceLabel";
            this.compChoiceLabel.Size = new System.Drawing.Size(147, 20);
            this.compChoiceLabel.TabIndex = 0;
            this.compChoiceLabel.Text = "Computer\'s Choice:";
            this.compChoiceLabel.Visible = false;
            // 
            // computerChoice
            // 
            this.computerChoice.AutoSize = true;
            this.computerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoice.Location = new System.Drawing.Point(189, 138);
            this.computerChoice.Name = "computerChoice";
            this.computerChoice.Size = new System.Drawing.Size(99, 25);
            this.computerChoice.TabIndex = 1;
            this.computerChoice.Text = "scissors";
            this.computerChoice.Visible = false;
            // 
            // yourChoiceLabel
            // 
            this.yourChoiceLabel.AutoSize = true;
            this.yourChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourChoiceLabel.Location = new System.Drawing.Point(188, 211);
            this.yourChoiceLabel.Name = "yourChoiceLabel";
            this.yourChoiceLabel.Size = new System.Drawing.Size(100, 20);
            this.yourChoiceLabel.TabIndex = 2;
            this.yourChoiceLabel.Text = "Your Choice:";
            this.yourChoiceLabel.Visible = false;
            // 
            // yourChoice
            // 
            this.yourChoice.AutoSize = true;
            this.yourChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourChoice.Location = new System.Drawing.Point(189, 258);
            this.yourChoice.Name = "yourChoice";
            this.yourChoice.Size = new System.Drawing.Size(99, 25);
            this.yourChoice.TabIndex = 3;
            this.yourChoice.Text = "scissors";
            this.yourChoice.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(251, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 37);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Location = new System.Drawing.Point(47, 53);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(63, 13);
            this.yourScoreLabel.TabIndex = 8;
            this.yourScoreLabel.Text = "Your Score:";
            // 
            // yourScoreOutput
            // 
            this.yourScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yourScoreOutput.Location = new System.Drawing.Point(116, 52);
            this.yourScoreOutput.Name = "yourScoreOutput";
            this.yourScoreOutput.Size = new System.Drawing.Size(23, 19);
            this.yourScoreOutput.TabIndex = 9;
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Location = new System.Drawing.Point(308, 53);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(93, 13);
            this.computerScoreLabel.TabIndex = 10;
            this.computerScoreLabel.Text = "Computer\'s Score:";
            // 
            // computerScoreOutput
            // 
            this.computerScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerScoreOutput.Location = new System.Drawing.Point(407, 52);
            this.computerScoreOutput.Name = "computerScoreOutput";
            this.computerScoreOutput.Size = new System.Drawing.Size(23, 19);
            this.computerScoreOutput.TabIndex = 11;
            // 
            // makeSelectionLabel
            // 
            this.makeSelectionLabel.AutoSize = true;
            this.makeSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeSelectionLabel.Location = new System.Drawing.Point(129, 217);
            this.makeSelectionLabel.Name = "makeSelectionLabel";
            this.makeSelectionLabel.Size = new System.Drawing.Size(218, 24);
            this.makeSelectionLabel.TabIndex = 12;
            this.makeSelectionLabel.Text = "Please make a selection:";
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.Checked = true;
            this.rockRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockRadioButton.Location = new System.Drawing.Point(104, 316);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(64, 24);
            this.rockRadioButton.TabIndex = 13;
            this.rockRadioButton.TabStop = true;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = true;
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperRadioButton.Location = new System.Drawing.Point(192, 316);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(69, 24);
            this.paperRadioButton.TabIndex = 14;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsRadioButton.Location = new System.Drawing.Point(285, 316);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(87, 24);
            this.scissorsRadioButton.TabIndex = 15;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(131, 381);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(94, 37);
            this.goButton.TabIndex = 16;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // rockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 470);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.scissorsRadioButton);
            this.Controls.Add(this.paperRadioButton);
            this.Controls.Add(this.rockRadioButton);
            this.Controls.Add(this.makeSelectionLabel);
            this.Controls.Add(this.computerScoreOutput);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.yourScoreOutput);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.yourChoice);
            this.Controls.Add(this.yourChoiceLabel);
            this.Controls.Add(this.computerChoice);
            this.Controls.Add(this.compChoiceLabel);
            this.Name = "rockPaperScissorsForm";
            this.Text = "Rock, Paper, Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compChoiceLabel;
        private System.Windows.Forms.Label computerChoice;
        private System.Windows.Forms.Label yourChoiceLabel;
        private System.Windows.Forms.Label yourChoice;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label yourScoreOutput;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label computerScoreOutput;
        private System.Windows.Forms.Label makeSelectionLabel;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.Button goButton;
    }
}

