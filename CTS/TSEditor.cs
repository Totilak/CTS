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
using CTS.Classes;


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_1_2_TextChanged(object sender, EventArgs e)
        {
            textBox3_2_1_2.Text = ($"Должно быть обеспечено информационно - техническое сопряжение комплекса {textBox3_1_2.Text} со следующими радиоэлектронными средствами и корабельными системами заказа проекта  < >: ");
        }

        private void label3_2_1_3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_2_1_2_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_2_1_2_1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_2_1_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_2_1_4_Click(object sender, EventArgs e)
        {

        }

        private void label3_2_2_Click(object sender, EventArgs e)
        {

        }

        private void label3_2_2_1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_2_2_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_2_2_2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_2_2_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_2_2_3_Click(object sender, EventArgs e)
        {

        }

        private void label3_2_3_Click(object sender, EventArgs e)
        {

        }

        private void label3_2_3_1_Click(object sender, EventArgs e)
        {

        }

        private void label3_2_4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_2_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_2_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_2_5_Click(object sender, EventArgs e)
        {

        }

        private void label3_3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_5_Click(object sender, EventArgs e)
        {

        }

        private void label3_6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_8_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_8_2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_8_2_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_8_2_1_Click(object sender, EventArgs e)
        {

        }

        private void label3_8_2_2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_8_2_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_8_1_Click(object sender, EventArgs e)
        {

        }

        private void label3_8_2_3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddlist3_2_1_2_Click(object sender, EventArgs e)
        {
              List<string> list = new List<string>();

            SelectForms.SelectList3_2_1_2 selectList= new SelectForms.SelectList3_2_1_2(list);
            selectList.ShowDialog();
            list = selectList.listOfSomething;


            foreach (string item in list)
            {
                textBox3_2_1_21.AppendText(item + Environment.NewLine);
            }





        }

        private void textBox5_1_TextChanged(object sender, EventArgs e)
        {

        }














        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DoText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void DoText()
        {
            // Создание приложения Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            // Создание нового документа
            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();

            // Установка шрифта и размера шрифта для всего документа
            doc.Content.Font.Name = "Times New Roman";
            doc.Content.Font.Size = 14;

            // Добавление параграфов в документ
            AddParagraphToDocument(doc, GetSubparagraphsPoint1());
            AddParagraphToDocument(doc, GetSubparagraphsPoint2());
            AddParagraphToDocument(doc, GetSubparagraphsPoint3());
            AddParagraphToDocument(doc, GetSubparagraphsPoint4());
            AddParagraphToDocument(doc, GetSubparagraphsPoint5());
            AddParagraphToDocument(doc, GetSubparagraphsPoint6());

            // Инициализация диалогового окна сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Documents|*.docx";
            saveFileDialog.Title = "Сохранить файл Word";
            saveFileDialog.ShowDialog();

            // Если пользователь выбрал место сохранения файла и нажал ОК
            if (saveFileDialog.FileName != "")
            {
                // Сохранение документа по выбранному пути
                object filename = saveFileDialog.FileName;
                doc.SaveAs2(ref filename);

                // Закрытие Word
                wordApp.Quit();

                MessageBox.Show("Текст успешно экспортирован в Word!");
            }
        }
        private void AddParagraphToDocument(Microsoft.Office.Interop.Word.Document doc, Paragraph paragraph)
        {
            try
            {
                // Добавление заголовка параграфа в документ
                Microsoft.Office.Interop.Word.Paragraph titleParagraph = doc.Paragraphs.Add();
                titleParagraph.Range.Text += paragraph.Title;
                titleParagraph.Range.InsertParagraphBefore();
                titleParagraph.Range.Font.Bold = 1;

                // Создаем диапазон для текста подпунктов и смещаемся на одну строку ниже заголовка
                Microsoft.Office.Interop.Word.Range subRange = titleParagraph.Range.Paragraphs.Last.Range;
                subRange.InsertParagraphAfter();
                subRange = titleParagraph.Range.Paragraphs.Last.Range;

                foreach (Subparagraph subparagraph in paragraph.Subparagraphs)
                {
                    // Добавляем заголовок и текст подпункта с дополнительной табуляцией перед текстом подпункта
                    subRange.InsertAfter($"\n{subparagraph.Title}\t{subparagraph.Text}");
                    // Не устанавливаем жирность для текста подзаголовка
                    subRange.Font.Bold = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private Paragraph GetSubparagraphsPoint1()
        {
            //Point 1
            Paragraph result = new Paragraph();
            result.Title = groupBox1.Text;

            result.Subparagraphs.Add(new Subparagraph { Title = label1_1.Text, Number = "1.1", Text = textBox1_1.Text });

/*            if (textBox1_2.Text == "1.2 <Если поле не используется, оставить пустым>" || textBox1_2.Text == "")
            {
                result.Subparagraphs.Add(new Subparagraph { Title = label1_3.Text, Number = "1.2", Text = textBox1_3.Text });
                result.Subparagraphs.Add(new Subparagraph { Title = label1_4.Text, Number = "1.3", Text = comboBox1_4.Text });
                result.Subparagraphs.Add(new Subparagraph { Title = label1_5.Text, Number = "1.4", Text = comboBox1_5.Text });
                result.Subparagraphs.Add(new Subparagraph { Title = label1_6.Text, Number = "1.5", Text = comboBox1_6.Text });
                result.Subparagraphs.Add(new Subparagraph { Title = label1_7_1.Text, Number = "1.6", Text = $"{comboBox1_7_1.Text} {label1_7_2.Text} {comboBox1_7_2.Text} {label1_7_3.Text} {comboBox1_7_3.Text}" });
            }*/

            result.Subparagraphs.Add(new Subparagraph { Title = textBox1_2.Text, Number = "1.2", Text = "" });
            result.Subparagraphs.Add(new Subparagraph { Title = label1_3.Text, Number = "1.3", Text = textBox1_3.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label1_4.Text, Number = "1.4", Text = comboBox1_4.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label1_5.Text, Number = "1.5", Text = comboBox1_5.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label1_6.Text, Number = "1.6", Text = comboBox1_6.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label1_7_1.Text, Number = "1.7", Text = $"{comboBox1_7_1.Text} {label1_7_2.Text} {comboBox1_7_2.Text} {label1_7_3.Text} {comboBox1_7_3.Text}" });

            return result;
        }

        private Paragraph GetSubparagraphsPoint2()
        {
            //Point 2
            Paragraph result = new Paragraph();
            result.Title = groupBox2.Text;

            result.Subparagraphs.Add(new Subparagraph { Title = label2.Text, Number = "2.1", Text = textBox2_1.Text });
           
            return result;
        }

        private Paragraph GetSubparagraphsPoint3()
        {
            //Point 3
            Paragraph result = new Paragraph();
            result.Title = groupBox3.Text;



            result.Subparagraphs.Add(new Subparagraph { Title = label3_1.Text, Number = "3.1", Text = "" });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_1_1.Text, Number = "3.1.1", Text = textBox3_1_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_1_2.Text, Number = "3.1.2", Text = textBox3_1_2.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_1_3.Text, Number = "3.1.3", Text = textBox3_1_3.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_2.Text, Number = "3.2", Text = $"{label3_21.Text} {textBox3_2.Text}" });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_1.Text, Number = "3.2.1", Text = $"" });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_1_1.Text, Number = "3.2.1.1", Text = textBox3_2_1_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_1_2.Text, Number = "3.2.1.2", Text = ($"{textBox3_2_1_2.Text}" + Environment.NewLine + textBox3_2_1_21.Text) });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_1_2_1.Text, Number = "3.2.1.2.1", Text = textBox3_2_1_2_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_1_3.Text, Number = "3.2.1.3", Text = textBox3_2_1_3.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_1_4.Text, Number = "3.2.1.4", Text = textBox3_2_1_4.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_2.Text, Number = "3.2.2", Text = "" });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_2_1.Text, Number = "3.2.2.1", Text = textBox3_2_2_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_2_2.Text, Number = "3.2.2.2", Text = textBox3_2_2_2.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_2_3.Text, Number = "3.2.2.3", Text = textBox3_2_2_3.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_3.Text, Number = "3.2.3", Text = "" });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_3_1.Text, Number = "3.2.3.1", Text = textBox3_2_3_1.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_4.Text, Number = "3.2.4", Text = textBox3_2_4.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_2_5.Text, Number = "3.2.5", Text = textBox3_2_5.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_3.Text, Number = "3.3", Text = textBox3_3.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_4.Text, Number = "3.4", Text = textBox3_4.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_5.Text, Number = "3.5", Text = textBox3_5.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_6.Text, Number = "3.6", Text = textBox3_6.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_7.Text, Number = "3.7", Text = textBox3_7.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_8.Text, Number = "3.8", Text = "" });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_8_1.Text, Number = "3.8.1", Text = textBox3_8_1 .Text});

            result.Subparagraphs.Add(new Subparagraph { Title = label3_8_2.Text, Number = "3.8.2", Text = "" });

            result.Subparagraphs.Add(new Subparagraph { Title = label3_8_2_1.Text, Number = "3.8.2.1", Text = textBox3_8_2_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_8_2_2.Text, Number = "3.8.2.2", Text = textBox3_8_2_2.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label3_8_2_3.Text, Number = "3.8.2.3", Text = textBox3_8_2_3.Text });

            result.Subparagraphs.Add(new Subparagraph { Title ="", Number = "3.End", Text = textBox3_end.Text });

            return result;
        }

        private Paragraph GetSubparagraphsPoint4()
        {
            //Point 4
            Paragraph result = new Paragraph();
            result.Title = groupBox4.Text;

            result.Subparagraphs.Add(new Subparagraph { Title = label4_1.Text, Number = "4.1", Text = textBox4_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label4_2.Text, Number = "4.2", Text = textBox4_2.Text });
            result.Subparagraphs.Add(new Subparagraph { Title ="", Number = "4.End", Text = textBox4_end.Text });

            return result;
        }

        private Paragraph GetSubparagraphsPoint5()
        {
            //Point 5
            Paragraph result = new Paragraph();
            result.Title = groupBox5.Text;

            result.Subparagraphs.Add(new Subparagraph { Title = "", Number = "5.0", Text = textBox51.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label5_1.Text, Number = "5.1", Text = "" });
            result.Subparagraphs.Add(new Subparagraph { Title = label5_1_1.Text, Number = "5.1.1", Text = textBox5_1.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label5_1_2.Text, Number = "5.1.2", Text = textBox5_1_2.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label5_1_3.Text, Number = "5.1.3", Text = textBox5_1_3.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = "", Number = "5.End", Text = textBox5_end.Text });

            return result;
        }

        private Paragraph GetSubparagraphsPoint6()
        {
            //Point 6
            Paragraph result = new Paragraph();
            result.Title = groupBox6.Text;

            result.Subparagraphs.Add(new Subparagraph { Title = label6_1.Text, Number = "6.1", Text = textBox6_1.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = label6_2.Text, Number = "6.2", Text = textBox6_2 .Text});
            result.Subparagraphs.Add(new Subparagraph { Title = label6_3.Text, Number = "6.3", Text = textBox6_3.Text });

            result.Subparagraphs.Add(new Subparagraph { Title = label6_4.Text, Number = "6.4", Text = textBox6_4.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = "", Number = "6.4.1", Text = textBox6_41.Text });
            result.Subparagraphs.Add(new Subparagraph { Title = "", Number = "6.End", Text = textBox6_end.Text });

            return result;
        }










    }
}
