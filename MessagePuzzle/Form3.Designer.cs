namespace MessagePuzzle
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(132, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 95);
            label2.Name = "label2";
            label2.Size = new Size(464, 96);
            label2.TabIndex = 1;
            label2.Text = "W projekcie wykorzystano technologie: Windows Forms, listing z języka python oraz przy użyciu base64 encodowaliśmy ciągi znaków.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 218);
            label3.Name = "label3";
            label3.Size = new Size(128, 46);
            label3.TabIndex = 2;
            label3.Text = "Hasło";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 284);
            label5.Name = "label5";
            label5.Size = new Size(109, 24);
            label5.TabIndex = 4;
            label5.Text = "A = Weź ki";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(276, 284);
            label6.Name = "label6";
            label6.Size = new Size(111, 24);
            label6.TabIndex = 5;
            label6.Text = "B = erunek";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(478, 284);
            label7.Name = "label7";
            label7.Size = new Size(111, 24);
            label7.TabIndex = 6;
            label7.Text = "C = na UZ!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(62, 342);
            label8.Name = "label8";
            label8.Size = new Size(660, 75);
            label8.TabIndex = 7;
            label8.Text = "Weź kierunek na UZ!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}