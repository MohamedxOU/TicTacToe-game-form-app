namespace TicTacToe_MED
{
    partial class StartInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.starInterfaceHeading = new System.Windows.Forms.Label();
            this.playersNamesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartGame2PlayerBtn = new System.Windows.Forms.Button();
            this.goToStrtChoiceBtn = new System.Windows.Forms.Button();
            this.versusRobotGameButton = new System.Windows.Forms.Button();
            this.twoPlayersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.playersNamesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.playersNamesPanel);
            this.panel1.Controls.Add(this.versusRobotGameButton);
            this.panel1.Controls.Add(this.twoPlayersButton);
            this.panel1.Controls.Add(this.starInterfaceHeading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 375);
            this.panel1.TabIndex = 0;
            // 
            // starInterfaceHeading
            // 
            this.starInterfaceHeading.AutoSize = true;
            this.starInterfaceHeading.BackColor = System.Drawing.Color.Gainsboro;
            this.starInterfaceHeading.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starInterfaceHeading.ForeColor = System.Drawing.Color.SeaGreen;
            this.starInterfaceHeading.Location = new System.Drawing.Point(100, 35);
            this.starInterfaceHeading.Name = "starInterfaceHeading";
            this.starInterfaceHeading.Size = new System.Drawing.Size(200, 40);
            this.starInterfaceHeading.TabIndex = 0;
            this.starInterfaceHeading.Text = "TIC TAC TOE";
            // 
            // playersNamesPanel
            // 
            this.playersNamesPanel.Controls.Add(this.goToStrtChoiceBtn);
            this.playersNamesPanel.Controls.Add(this.StartGame2PlayerBtn);
            this.playersNamesPanel.Controls.Add(this.player2NameTextBox);
            this.playersNamesPanel.Controls.Add(this.label2);
            this.playersNamesPanel.Controls.Add(this.player1NameTextBox);
            this.playersNamesPanel.Controls.Add(this.label1);
            this.playersNamesPanel.Location = new System.Drawing.Point(63, 91);
            this.playersNamesPanel.Name = "playersNamesPanel";
            this.playersNamesPanel.Size = new System.Drawing.Size(272, 197);
            this.playersNamesPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 name :";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Location = new System.Drawing.Point(108, 18);
            this.player1NameTextBox.Multiline = true;
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.player1NameTextBox.TabIndex = 1;
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Location = new System.Drawing.Point(109, 56);
            this.player2NameTextBox.Multiline = true;
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.player2NameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2 name :";
            // 
            // StartGame2PlayerBtn
            // 
            this.StartGame2PlayerBtn.BackColor = System.Drawing.Color.Green;
            this.StartGame2PlayerBtn.FlatAppearance.BorderSize = 0;
            this.StartGame2PlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame2PlayerBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame2PlayerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartGame2PlayerBtn.Location = new System.Drawing.Point(73, 106);
            this.StartGame2PlayerBtn.Name = "StartGame2PlayerBtn";
            this.StartGame2PlayerBtn.Size = new System.Drawing.Size(133, 29);
            this.StartGame2PlayerBtn.TabIndex = 4;
            this.StartGame2PlayerBtn.Text = "Start playing";
            this.StartGame2PlayerBtn.UseVisualStyleBackColor = false;
            this.StartGame2PlayerBtn.Click += new System.EventHandler(this.StartGame2PlayerBtn_Click);
            // 
            // goToStrtChoiceBtn
            // 
            this.goToStrtChoiceBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.goToStrtChoiceBtn.FlatAppearance.BorderSize = 0;
            this.goToStrtChoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToStrtChoiceBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToStrtChoiceBtn.ForeColor = System.Drawing.Color.DimGray;
            this.goToStrtChoiceBtn.Location = new System.Drawing.Point(73, 142);
            this.goToStrtChoiceBtn.Name = "goToStrtChoiceBtn";
            this.goToStrtChoiceBtn.Size = new System.Drawing.Size(133, 29);
            this.goToStrtChoiceBtn.TabIndex = 5;
            this.goToStrtChoiceBtn.Text = "Go back";
            this.goToStrtChoiceBtn.UseVisualStyleBackColor = false;
            this.goToStrtChoiceBtn.Click += new System.EventHandler(this.goToStrtChoiceBtn_Click);
            // 
            // versusRobotGameButton
            // 
            this.versusRobotGameButton.BackColor = System.Drawing.Color.Honeydew;
            this.versusRobotGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versusRobotGameButton.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusRobotGameButton.Image = global::TicTacToe_MED.Properties.Resources.robot__1_;
            this.versusRobotGameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.versusRobotGameButton.Location = new System.Drawing.Point(97, 197);
            this.versusRobotGameButton.Name = "versusRobotGameButton";
            this.versusRobotGameButton.Size = new System.Drawing.Size(203, 64);
            this.versusRobotGameButton.TabIndex = 2;
            this.versusRobotGameButton.Text = "VS robot";
            this.versusRobotGameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.versusRobotGameButton.UseVisualStyleBackColor = false;
            this.versusRobotGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // twoPlayersButton
            // 
            this.twoPlayersButton.BackColor = System.Drawing.Color.Honeydew;
            this.twoPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoPlayersButton.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayersButton.Image = global::TicTacToe_MED.Properties.Resources.user__1_;
            this.twoPlayersButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.twoPlayersButton.Location = new System.Drawing.Point(97, 118);
            this.twoPlayersButton.Name = "twoPlayersButton";
            this.twoPlayersButton.Size = new System.Drawing.Size(203, 64);
            this.twoPlayersButton.TabIndex = 1;
            this.twoPlayersButton.Text = "Two playes";
            this.twoPlayersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.twoPlayersButton.UseVisualStyleBackColor = false;
            this.twoPlayersButton.Click += new System.EventHandler(this.twoPlayersButton_Click);
            // 
            // StartInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 373);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StartInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.playersNamesPanel.ResumeLayout(false);
            this.playersNamesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label starInterfaceHeading;
        private System.Windows.Forms.Button twoPlayersButton;
        private System.Windows.Forms.Button versusRobotGameButton;
        private System.Windows.Forms.Panel playersNamesPanel;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartGame2PlayerBtn;
        private System.Windows.Forms.Button goToStrtChoiceBtn;
    }
}

