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
    public partial class DecodedMessage : Form
    {
        public DecodedMessage()
        {
            InitializeComponent();
        }

        public DecodedMessage(string message)
        {
            InitializeComponent();
            textBoxDecodedMessage.Text = message;//Получаем дешифрованное сообщение и выводим его 
        }

        private void buttonCloseDecodeMessage_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
