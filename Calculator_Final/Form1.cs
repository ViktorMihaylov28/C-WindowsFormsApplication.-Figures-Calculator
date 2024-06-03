using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 20; //Parametri na progres bara
            progressBar1.Paint += ProgressBar1_Paint;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button1.Text = "Затвори";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Kvadrat
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label4.Text = "Периметър: ";
            label5.Text = "Лице: ";
            button1.Text = "Пресметни";
            label1.Text = "Въведете страната А";
            textBox1.Clear(); //Izchistva poleto ako sme smenili ot drug radiobuton v koito e bil populnen textboksa
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Krug
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label4.Text = "Дължина";
            label5.Text = "Лице: ";
            textBox1.Clear();
            button1.Text = "Пресметни";
            label1.Text = "Константа π";
            textBox1.Text = "3.14159265359";
            label2.Text = "Радиус";
            textBox2.Clear();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Pravougulnik
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label4.Text = "Периметър: ";
            label5.Text = "Лице: ";
            button1.Text = "Пресметни";
            label1.Text = "Страната А";
            textBox1.Clear();
            label2.Text = "Страната B";
            textBox2.Clear();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Romb
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label4.Text = "Периметър: ";
            label5.Text = "Лице: ";
            button1.Text = "Пресметни";
            label1.Text = "Страната A или B или C";
            label2.Text = "Височина към страната";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Triugulnik
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label4.Text = "Периметър: ";
            label5.Text = "Лице: ";
            button1.Text = "Пресметни";
            label1.Text = "Страната A";
            label2.Text = "Страната B";
            label3.Text = "Страната C";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //Usporednik
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label4.Text = "Периметър: ";
            label5.Text = "Лице: ";
            button1.Text = "Пресметни";
            label1.Text = "Страната A";
            label2.Text = "Страната B";
            label3.Text = "Височина към страната";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Trapec
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label4.Text = "Периметър: ";
            label5.Text = "Лице: ";
            button1.Text = "Пресметни";
            label1.Text = "Основа A";
            label2.Text = "Основа B";
            label3.Text = "Бедро C";
            label8.Text = "Бедро D";
            label9.Text = "Височина към страната";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool buttonClicked = false;

        private void ProgressBar1_Paint(object sender, PaintEventArgs e)
        {
            // Изчертаваме текущия процент на прогрес бара
            using (Font font = new Font("Arial", 8.25f, FontStyle.Regular))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                int percent = progressBar1.Value * 5;
                string text = percent + "%";
                SizeF textSize = e.Graphics.MeasureString(text, font);
                float x = progressBar1.Width / 2 - textSize.Width / 2;
                float y = progressBar1.Height / 2 - textSize.Height / 2;
                e.Graphics.DrawString(text, font, brush, x, y);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            // Проверка за избрана геометрична фигура
            if (radioButton1.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                if (!buttonClicked)
                {
                    buttonClicked = true;
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                button1.Text = buttonClicked ? "Затвори" : "Пресметни";
            }

            // Активиране на прогрес бара
            button1.Enabled = false;
            progressBar1.Visible = true;

            for (int i = 1; i <= 20; i++)
            {
                progressBar1.Value = i;
                progressBar1.CreateGraphics().DrawString(i * 5 + "%", new Font("Arial", (float)12, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                await Task.Delay(1000);
            }

            // Изчисляване и показване на резултата
            if (radioButton2.Checked) // Избран квадрат
            {
                double strana_a;
                if (double.TryParse(textBox1.Text, out strana_a))
                {
                    double lice = strana_a * strana_a;
                    double perimetur = strana_a * 4;
                    label6.Text = perimetur.ToString();
                    label7.Text = lice.ToString();
                }
                else
                {
                    MessageBox.Show("Грешка при въвеждането на страната на квадрата.");
                }
            }
            else if (radioButton3.Checked) // Избран кръг
            {
                double radius;
                if (double.TryParse(textBox2.Text, out radius))
                {
                    double duljina = 2 * Math.PI * radius;
                    label6.Text = duljina.ToString();
                    double lice = Math.PI * radius * radius;
                    label7.Text = (Math.Round(lice, 8)).ToString();
                }
                else
                {
                    MessageBox.Show("Грешка при въвеждането на данни за кръга.");
                }
            }
            else if(radioButton4.Checked) //Избран правоъгълник
            {
                double strana_a;
                double strana_b;
                if(double.TryParse(textBox1.Text, out strana_a) && double.TryParse(textBox2.Text, out strana_b))
                {
                    double perimetur = (strana_a * 2) + (strana_b * 2);
                    double lice = strana_a * strana_b;
                    label6.Text = perimetur.ToString();
                    label7.Text = lice.ToString();
                }
                else
                {
                    MessageBox.Show("Грешка при въвеждането на данни за правоъгълника.");
                }
            }
            else if(radioButton5.Checked) //Избран ромб
            {
                double strana_a;
                double visochina;
                if(double.TryParse(textBox1.Text, out strana_a) && double.TryParse(textBox2.Text, out visochina))
                {
                    double perimeter = 4 * strana_a;
                    double lice = strana_a * visochina;
                    label6.Text = perimeter.ToString();
                    label7.Text = lice.ToString();
                }
                else
                {
                    MessageBox.Show("Грешка при въвеждането на данни за ромба.");
                }
            }
            else if(radioButton6.Checked) //Избран триъгълник
            {
                double strana_a;
                double strana_b;
                double strana_c;
                if(double.TryParse(textBox1.Text, out strana_a) && double.TryParse(textBox2.Text, out strana_b) && double.TryParse(textBox3.Text, out strana_c))
                {
                    double perimeter = strana_a + strana_b + strana_c;
                    label6.Text = perimeter.ToString();
                    double polu_peremeter = perimeter / 2;
                    double lice = Math.Sqrt(polu_peremeter * ((polu_peremeter - strana_a) * (polu_peremeter - strana_b) * (polu_peremeter - strana_c)));
                    label7.Text = lice.ToString();
                }
                else
                {
                    MessageBox.Show("Грешка при въвеждането на данни за триъгълника.");
                }
            }
            else if(radioButton7.Checked) //Избран успоредник
            {
                double strana_a;
                double strana_b;
                double visochina;
                if(double.TryParse(textBox1.Text, out strana_a) && double.TryParse(textBox2.Text, out strana_b) && double.TryParse(textBox3.Text, out visochina))
                {
                    double perimeter = (2 * strana_b) + (2 * strana_a);
                    double lice = (strana_a * visochina) / 2;
                    label6.Text = perimeter.ToString();
                    label7.Text = lice.ToString();
                }
            }
            else if(radioButton8.Checked) //Избран трапец
            {
                double a;
                double c;
                double b;
                double d;
                double visochina;
                if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out c) && double.TryParse(textBox4.Text, out d) && double.TryParse(textBox5.Text, out visochina))
                {
                    double perimeter = a + c + b + d;
                    label6.Text = perimeter.ToString();
                    double lice = ((a + b) * visochina) / 2;
                    label7.Text = lice.ToString();
                }
            }
            // Други случаи за други фигури...

            button1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да затворите програмата?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}