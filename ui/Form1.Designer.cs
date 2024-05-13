namespace ui
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            buttonPlay = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panelGame = new Panel();
            messageLabel = new Label();
            PlayerInput = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelGame.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPlay);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 450);
            panel1.TabIndex = 0;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.DarkSlateGray;
            buttonPlay.BackgroundImageLayout = ImageLayout.None;
            buttonPlay.Dock = DockStyle.Top;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPlay.ForeColor = SystemColors.ActiveCaption;
            buttonPlay.Location = new Point(0, 112);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(219, 103);
            buttonPlay.TabIndex = 2;
            buttonPlay.Text = "Jouer";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            buttonPlay.MouseHover += buttonPlay_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 112);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(38, 42);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 0;
            label1.Text = "L3 FASI ";
            // 
            // panelGame
            // 
            panelGame.BorderStyle = BorderStyle.FixedSingle;
            panelGame.Controls.Add(messageLabel);
            panelGame.Controls.Add(PlayerInput);
            panelGame.Controls.Add(label2);
            panelGame.Dock = DockStyle.Fill;
            panelGame.Location = new Point(219, 0);
            panelGame.Name = "panelGame";
            panelGame.Padding = new Padding(15);
            panelGame.Size = new Size(581, 450);
            panelGame.TabIndex = 1;
            panelGame.Paint += panelGame_Paint;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(193, 314);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(12, 20);
            messageLabel.TabIndex = 3;
            messageLabel.Text = ".";
            // 
            // PlayerInput
            // 
            PlayerInput.AccessibleRole = AccessibleRole.Pane;
            PlayerInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayerInput.BackColor = Color.DarkSlateGray;
            PlayerInput.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PlayerInput.ForeColor = SystemColors.ActiveCaption;
            PlayerInput.Location = new Point(204, 203);
            PlayerInput.Margin = new Padding(30, 3, 3, 30);
            PlayerInput.Name = "PlayerInput";
            PlayerInput.Size = new Size(163, 53);
            PlayerInput.TabIndex = 2;
            PlayerInput.TextAlign = HorizontalAlignment.Center;
            PlayerInput.KeyPress += PlayerInput_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(166, 24);
            label2.Name = "label2";
            label2.Size = new Size(271, 40);
            label2.TabIndex = 1;
            label2.Text = "Mode Standard";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGame);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private Button buttonPlay;
        private Label label1;
        private Panel panelGame;
        private Label label2;
        private TextBox PlayerInput;
        private Label messageLabel;
    }
}
