namespace MessagePuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            instrukcja = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top;
            progressBar1.Location = new Point(150, 10);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(703, 20);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 61);
            label1.Name = "label1";
            label1.Size = new Size(58, 27);
            label1.TabIndex = 2;
            label1.Text = "0:00";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(869, 10);
            tableLayoutPanel1.MaximumSize = new Size(100, 100);
            tableLayoutPanel1.MinimumSize = new Size(100, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(100, 100);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // instrukcja
            // 
            instrukcja.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            instrukcja.Location = new Point(114, 163);
            instrukcja.Name = "instrukcja";
            instrukcja.Size = new Size(700, 236);
            instrukcja.TabIndex = 5;
            instrukcja.Text = resources.GetString("instrukcja.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(114, 69);
            label2.Name = "label2";
            label2.Size = new Size(468, 32);
            label2.TabIndex = 6;
            label2.Text = "Witaj w programie MessagePuzzle!";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(866, 133);
            button2.Name = "button2";
            button2.Size = new Size(103, 39);
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "Podpowiedź";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 34F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(303, 399);
            label3.Name = "label3";
            label3.Size = new Size(358, 65);
            label3.TabIndex = 8;
            label3.Text = " Powodzenia!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Enabled = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(866, 417);
            button3.Name = "button3";
            button3.Size = new Size(100, 47);
            button3.TabIndex = 9;
            button3.Text = "Poddaj się";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(984, 500);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(instrukcja);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label instrukcja;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
    }
}