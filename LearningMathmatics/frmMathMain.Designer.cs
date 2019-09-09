namespace LearningMathmatics
{
    partial class frmMathMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathMain));
            this.tmeUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lblYourAnswer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMakeQuestion = new System.Windows.Forms.Button();
            this.lblTried = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblTimesTried = new System.Windows.Forms.Label();
            this.pbxAnimation = new System.Windows.Forms.PictureBox();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.lblEasterEgg = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmeDrain = new System.Windows.Forms.Timer(this.components);
            this.pbxHelp = new System.Windows.Forms.PictureBox();
            this.lblProfessional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // tmeUpdate
            // 
            this.tmeUpdate.Enabled = true;
            this.tmeUpdate.Interval = 30;
            this.tmeUpdate.Tick += new System.EventHandler(this.tmeUpdate_Tick);
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.Color.DimGray;
            this.tbxInput.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.ForeColor = System.Drawing.Color.Orange;
            this.tbxInput.Location = new System.Drawing.Point(533, 418);
            this.tbxInput.MaxLength = 4;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(240, 97);
            this.tbxInput.TabIndex = 2;
            this.tbxInput.Text = "9999";
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYourAnswer
            // 
            this.lblYourAnswer.AutoSize = true;
            this.lblYourAnswer.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAnswer.ForeColor = System.Drawing.Color.White;
            this.lblYourAnswer.Location = new System.Drawing.Point(122, 451);
            this.lblYourAnswer.Name = "lblYourAnswer";
            this.lblYourAnswer.Size = new System.Drawing.Size(405, 64);
            this.lblYourAnswer.TabIndex = 3;
            this.lblYourAnswer.Text = "Your Answer =";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Orange;
            this.btnSubmit.Location = new System.Drawing.Point(533, 521);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(240, 68);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMakeQuestion
            // 
            this.btnMakeQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeQuestion.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeQuestion.ForeColor = System.Drawing.Color.Orange;
            this.btnMakeQuestion.Location = new System.Drawing.Point(318, 12);
            this.btnMakeQuestion.Name = "btnMakeQuestion";
            this.btnMakeQuestion.Size = new System.Drawing.Size(178, 30);
            this.btnMakeQuestion.TabIndex = 5;
            this.btnMakeQuestion.Text = "&Next Question";
            this.btnMakeQuestion.UseVisualStyleBackColor = true;
            this.btnMakeQuestion.Click += new System.EventHandler(this.btnMakeQuestion_Click);
            // 
            // lblTried
            // 
            this.lblTried.AutoSize = true;
            this.lblTried.BackColor = System.Drawing.Color.Black;
            this.lblTried.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTried.ForeColor = System.Drawing.Color.Lime;
            this.lblTried.Location = new System.Drawing.Point(231, 550);
            this.lblTried.Name = "lblTried";
            this.lblTried.Size = new System.Drawing.Size(26, 28);
            this.lblTried.TabIndex = 34;
            this.lblTried.Text = "0";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Black;
            this.lblCorrect.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Lime;
            this.lblCorrect.Location = new System.Drawing.Point(230, 522);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(26, 28);
            this.lblCorrect.TabIndex = 33;
            this.lblCorrect.Text = "0";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.BackColor = System.Drawing.Color.Black;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.ForeColor = System.Drawing.Color.Lime;
            this.lblCorrectAnswers.Location = new System.Drawing.Point(8, 522);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(216, 28);
            this.lblCorrectAnswers.TabIndex = 32;
            this.lblCorrectAnswers.Text = "Correct answer times:";
            // 
            // lblTimesTried
            // 
            this.lblTimesTried.AutoSize = true;
            this.lblTimesTried.BackColor = System.Drawing.Color.Black;
            this.lblTimesTried.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesTried.ForeColor = System.Drawing.Color.Lime;
            this.lblTimesTried.Location = new System.Drawing.Point(50, 550);
            this.lblTimesTried.Name = "lblTimesTried";
            this.lblTimesTried.Size = new System.Drawing.Size(174, 28);
            this.lblTimesTried.TabIndex = 31;
            this.lblTimesTried.Text = "Total times tried:";
            // 
            // pbxAnimation
            // 
            this.pbxAnimation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAnimation.BackgroundImage")));
            this.pbxAnimation.Location = new System.Drawing.Point(0, 0);
            this.pbxAnimation.Margin = new System.Windows.Forms.Padding(0);
            this.pbxAnimation.Name = "pbxAnimation";
            this.pbxAnimation.Size = new System.Drawing.Size(800, 600);
            this.pbxAnimation.TabIndex = 0;
            this.pbxAnimation.TabStop = false;
            // 
            // prgProgress
            // 
            this.prgProgress.ForeColor = System.Drawing.Color.White;
            this.prgProgress.Location = new System.Drawing.Point(15, 372);
            this.prgProgress.Maximum = 350;
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(776, 23);
            this.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgress.TabIndex = 35;
            // 
            // lblEasterEgg
            // 
            this.lblEasterEgg.AutoSize = true;
            this.lblEasterEgg.ForeColor = System.Drawing.Color.White;
            this.lblEasterEgg.Location = new System.Drawing.Point(845, 448);
            this.lblEasterEgg.Name = "lblEasterEgg";
            this.lblEasterEgg.Size = new System.Drawing.Size(25, 13);
            this.lblEasterEgg.TabIndex = 38;
            this.lblEasterEgg.Text = "000";
            // 
            // lblProgress
            // 
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(675, 349);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(125, 20);
            this.lblProgress.TabIndex = 39;
            this.lblProgress.Text = "0 / 350";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlayer.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.ForeColor = System.Drawing.Color.Orange;
            this.btnNewPlayer.Location = new System.Drawing.Point(359, 521);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(168, 68);
            this.btnNewPlayer.TabIndex = 42;
            this.btnNewPlayer.Text = "&New Player";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Visible = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // tmeDrain
            // 
            this.tmeDrain.Interval = 2000;
            this.tmeDrain.Tick += new System.EventHandler(this.tmeDrain_Tick);
            // 
            // pbxHelp
            // 
            this.pbxHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxHelp.BackgroundImage")));
            this.pbxHelp.Location = new System.Drawing.Point(0, 0);
            this.pbxHelp.Margin = new System.Windows.Forms.Padding(0);
            this.pbxHelp.Name = "pbxHelp";
            this.pbxHelp.Size = new System.Drawing.Size(800, 600);
            this.pbxHelp.TabIndex = 44;
            this.pbxHelp.TabStop = false;
            this.pbxHelp.Click += new System.EventHandler(this.pbxHelp_Click);
            // 
            // lblProfessional
            // 
            this.lblProfessional.AutoSize = true;
            this.lblProfessional.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessional.ForeColor = System.Drawing.Color.Lime;
            this.lblProfessional.Location = new System.Drawing.Point(12, 418);
            this.lblProfessional.Name = "lblProfessional";
            this.lblProfessional.Size = new System.Drawing.Size(485, 39);
            this.lblProfessional.TabIndex = 45;
            this.lblProfessional.Text = "Well done, you are a Professional!!!";
            this.lblProfessional.Visible = false;
            // 
            // frmMathMain
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 601);
            this.Controls.Add(this.pbxHelp);
            this.Controls.Add(this.lblProfessional);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblEasterEgg);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.lblTried);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.lblTimesTried);
            this.Controls.Add(this.btnMakeQuestion);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblYourAnswer);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.pbxAnimation);
            this.Name = "frmMathMain";
            this.Text = "Learning Mathmatics";
            this.Load += new System.EventHandler(this.frmMathMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmeUpdate;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lblYourAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMakeQuestion;
        private System.Windows.Forms.Label lblTried;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblTimesTried;
        private System.Windows.Forms.PictureBox pbxAnimation;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.Label lblEasterEgg;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmeDrain;
        private System.Windows.Forms.PictureBox pbxHelp;
        private System.Windows.Forms.Label lblProfessional;
    }
}

