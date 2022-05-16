using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPUDP
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
            textBox_DefaultPort.Text = MCP_form.Get_defaultPort().ToString();
            textBoxIP.Text = MCP_form.Get_multicastIP().ToString();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Save_preferences_Click(object sender, EventArgs e)
        {
            MCP_form.Set_defaultPort(Convert.ToInt32(textBox_DefaultPort.Text));
            MCP_form.Set_multicastIP(textBoxIP.Text);

            #region Создание файла и запись данных в него
            //Создаем переменную для создания/удаления файла
            FileInfo fileInf = new FileInfo("Settings.ini");

            //Создаем переменную для записи в файл и создадем файл на жестком диске
            StreamWriter fileWrite = new StreamWriter(fileInf.Create());

            //Записываем построчно данные в файл
            fileWrite.WriteLine(textBox_DefaultPort.Text);
            fileWrite.WriteLine(textBoxIP.Text);

            //Сохраняем данные и закрываем файл
            fileWrite.Close();
            #endregion

            Close();
        }

        private void Cancel_Settings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
