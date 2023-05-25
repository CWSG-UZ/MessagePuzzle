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
    public partial class Form3 : Form
    {

        string time;

        public Form3(string time)
        {
            InitializeComponent();
            this.time = time;
            Text = "UZyskaj wiedzę z Informatyki!";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Twój czas to " + time;
        }
    }
}
