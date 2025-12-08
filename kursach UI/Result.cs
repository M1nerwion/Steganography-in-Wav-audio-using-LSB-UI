using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_UI
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public Result(string file_stego)
        {
            InitializeComponent();
            textBox1.Text = file_stego;//Получаем путь файла с шифрованной инфомрацией и выводим его в textbox
        }

        private void buttonCloseResult_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
