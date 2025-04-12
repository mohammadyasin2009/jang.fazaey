namespace jang
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(-501, -160);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1599, 682);
            axWindowsMediaPlayer1.TabIndex = 1;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(401, 40);
            button1.Name = "button1";
            button1.Size = new Size(160, 69);
            button1.TabIndex = 2;
            button1.Text = "Game with but";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(401, 172);
            button2.Name = "button2";
            button2.Size = new Size(160, 75);
            button2.TabIndex = 3;
            button2.Text = "Game with friend";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkOrange;
            button3.Location = new Point(69, 40);
            button3.Name = "button3";
            button3.Size = new Size(168, 69);
            button3.TabIndex = 4;
            button3.Text = "Multyplayer";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkOrange;
            button4.Location = new Point(69, 172);
            button4.Name = "button4";
            button4.Size = new Size(168, 74);
            button4.TabIndex = 5;
            button4.Text = "Setting";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 288);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form2";
            Text = "Form1";
            FormClosing += Form2_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
