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
            this.versusRobotGameButton = new System.Windows.Forms.Button();
            this.twoPlayersButton = new System.Windows.Forms.Button();
            this.starInterfaceHeading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.versusRobotGameButton);
            this.panel1.Controls.Add(this.twoPlayersButton);
            this.panel1.Controls.Add(this.starInterfaceHeading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 375);
            this.panel1.TabIndex = 0;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label starInterfaceHeading;
        private System.Windows.Forms.Button twoPlayersButton;
        private System.Windows.Forms.Button versusRobotGameButton;
    }
}

