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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            instrukcja = new Label();
            label2 = new Label();
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
            label1.Location = new Point(14, 61);
            label1.Name = "label1";
            label1.Size = new Size(71, 27);
            label1.TabIndex = 2;
            label1.Text = "15:00";
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
            instrukcja.AutoSize = true;
            instrukcja.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            instrukcja.Location = new Point(153, 92);
            instrukcja.Name = "instrukcja";
            instrukcja.Size = new Size(72, 18);
            instrukcja.TabIndex = 5;
            instrukcja.Text = "Instrukcja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(153, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 6;
            label2.Text = "Instrukcja";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(984, 461);
            Controls.Add(label2);
            Controls.Add(instrukcja);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(progressBar1);
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
    }
}