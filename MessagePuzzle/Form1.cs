using System.Diagnostics;

namespace MessagePuzzle
{
    public partial class Form1 : Form
    {

        private int secondsElapsed;
        private string[] hintArray;
        private int currentIndex;
        private Boolean isEveryHint = false;

        public Form1()
        {
            InitializeComponent();
            InitializeHintArray();
            Text = "MessagePuzzle";
        }

        private void InitializeHintArray()
        {
            hintArray = new string[]
            {
        "Zapisuj w notatniku rozszyfrowane fragmenty zmiennej a, b lub c. Wtedy łatwiej jest skleić ją w całość.",
        "sqrt oznacza pierwiastek kwadratowy z liczby przekazanej w nawiasie.",
        "return służy do zwracania wartości przez funkcję",
        "[:-1] usuwa ostatni element z listy",
        "[::-1] odwraca kolejność (na przykład ciągu znaków)",
        "[-2:] zwraca dwa ostatnie elementy listy",
        "Iterując po słowniku przechodzisz jedynie po jego kluczach",
        "pętla iterująca po enumerate daje dwie rzeczy, indeks i element",
        "% to operator modulo - reszta z dzielenia. Jeśli operacja % 2 jest równa 0 to liczba jest parzysta (bądź jest zerem)",
        "[:x] zwraca x pierwszych elementów listy bądź ciągu znaków."
            };
            currentIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            progressBar1.Left = (this.ClientSize.Width - progressBar1.Width) / 2;
            progressBar1.Dock = DockStyle.Top;
            tableLayoutPanel1.Top = progressBar1.Height + 10;
            tableLayoutPanel1.Left = this.ClientSize.Width - button1.Width - 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            label3.Location = new Point((this.ClientSize.Width - label3.Width) / 2, label3.Location.Y);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "listing.txt");
            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo { FileName = filePath, UseShellExecute = true });
                timer1.Enabled = true;
                button1.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;
                for (int i = 0; i < 3; i++)
                {
                    Form newForm = new Form();
                    newForm.Text = "New Form " + (i + 1);
                    newForm.Show();
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            secondsElapsed++;
            label1.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"m\:ss");
            if(secondsElapsed > 900 && isEveryHint)
            {
                button3.Enabled = true;
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex < hintArray.Length)
            {
                string message = hintArray[currentIndex];
                currentIndex++;
                MessageBox.Show(message, "Podpowiedź", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isEveryHint = true;
                currentIndex = 0;
                button2_Click(sender, e);
            }
        }
    }
}