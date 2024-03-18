using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS.SelectForms
{
    public partial class SelectList3_2_1_2 : Form
    {
        public List<string> listOfSomething = new List<string>();

        public SelectList3_2_1_2(List<String> list)
        {
            InitializeComponent();
            listOfSomething=list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                // Создаем список для хранения выбранных элементов

                // Перебираем выбранные элементы и добавляем их в список
                foreach (var selectedItem in listBox1.SelectedItems)
                {
                    listOfSomething.Add(selectedItem.ToString());
                }

                MessageBox.Show($"Выбранные элементы:   {listOfSomething.Count}");
                //listOfSomething=selectedItems;
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного элемента из списка.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
