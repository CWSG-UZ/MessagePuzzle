using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagePuzzle
{
    public partial class Form2 : Form
    {
        private string correctAnswer;
        public bool AnswerCorrect { get; private set; }
        public int number;

        public Form2(string correctAnswer, int number)
        {
            InitializeComponent();
            this.correctAnswer = correctAnswer;
            this.number = number;
            AnswerCorrect = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CP_NOCLOSE_BUTTON = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return cp;
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            switch (number)
            {
                case 0:
                    Text = "A";
                    label1.Text = "Wprowadź A";
                    break;
                case 1:
                    Text = "B";
                    label1.Text = "Wprowadź B";
                    break;
                case 2:
                    Text = "C";
                    label1.Text = "Wprowadz C";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userAnswer = textBox1.Text.Trim();

            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                AnswerCorrect = true;
                MessageBox.Show("Poprawna odpowiedź", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                AnswerCorrect = false;
                MessageBox.Show("Nieprawidłowa odpowiedź. Spróbuj ponownie!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
