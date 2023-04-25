using System.Diagnostics;

namespace MessagePuzzle
{
    public partial class Form1 : Form
    {

        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instrukcja.Text = "Za zadanie masz to i tamto";
            progressBar1.Left = (this.ClientSize.Width - progressBar1.Width) / 2;
            progressBar1.Dock = DockStyle.Top;
            tableLayoutPanel1.Top = progressBar1.Height + 10;
            tableLayoutPanel1.Left = this.ClientSize.Width - button1.Width - 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://pastebin.com/Vi1zGupx", UseShellExecute = true });
            startTime = DateTime.Now;
            timer1.Enabled = true;
            button1.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            int remainingSeconds = (int)Math.Max(0, (15 - elapsedTime.TotalSeconds));
            label1.Text = TimeSpan.FromSeconds(remainingSeconds).ToString(@"mm\:ss");

            if (remainingSeconds == 0)
            {
                label1.Text = "15:00";
                timer1.Enabled = false;
                progressBar1.Value = 0;
                button1.Enabled = true;
            }
        }
    }
}