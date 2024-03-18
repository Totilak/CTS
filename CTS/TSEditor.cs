using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CTS
{
    public partial class TSEditor : Form
    {
        // Импортировать функции для изменения размера окна и перемещения без рамки
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Константы для перемещения и изменения размера окна
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_SIZE = 0xF000;
        public TSEditor()
        {
            InitializeComponent();
        }

        // Обработчик события для перемещения окна
        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        // Обработчик события для изменения размера окна
        private void YourForm_MouseMove(object sender, MouseEventArgs e)
        {

        }






        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TSEditor_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти с формы? Все изменения не сохраняться!", "Подтвердите действие",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form1 form1 = new Form1(); // Создаем новую форму Form1
                this.Close(); // Закрываем текущую форму
                form1.Show(); // Показываем новую форму Form1
            }




        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void TSEditor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label1_3_Click(object sender, EventArgs e)
        {

        }
    }
}
