using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        Figure figure;
        public int count = 1;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.DeepSkyBlue, 5);
            Init.pictureBox = pictureBox1;
            richTextBoxCommandHistory.Visible = false;
            textBoxAutoFilling.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'R' || item == 'M' || item == 'E' || 
                item == 'C' || item == 'S' || item == ',' || 
                item == '(' || item == '('))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<string> names = new List<string>();
        public void AddName(string name)
        {
            names.Add(name);
        }
        public string FindName(string name)
        {
            foreach (string f in names)
            {
                if (f == name)
                {
                    return f;
                }
            }
            return null;
        }
        public void DeleteName(string name)
        {
            names.Remove(name);
        }
        public string lastName = "?";

        private void SelectingPerformingOperation(Operator op)
        {
            if (textBoxConsoleInput.Text[0] == 'E')
            {
                int h = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int w = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int y = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int x = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                string name = Convert.ToString(operands.Pop().value);
                if (FindName(name) != name)
                {
                    if (x + w < Init.pictureBox.Width && y + h < Init.pictureBox.Height)
                    {
                        figure = new Ellipse(name, x, y, w, h);
                        op = new Operator(figure.Draw, 'E');
                        ShapeContainer.AddFigure(figure);
                        comboBoxFigureList.Items.Add(figure.name);
                        op.operatorMethod();
                        AddName(name);
                        richTextBoxCommandHistory.Text += "[" + count + "]: " + "Фигура "+ name + " отрисована\n";
                        count++;
                        lastName = name;
                    }
                    else
                    {
                        MessageBox.Show("Фигура выходит за пределы холста", "Сообщение");
                        richTextBoxCommandHistory.Text += "[" + count + "]: " + "Поптыка создание фигуры " + name + " за пределами холста\n";
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Фигура с именем " + name + " уже существует", "Сообщение");
                    richTextBoxCommandHistory.Text += "[" + count + "]: " + "Поптыка создания существующей фигуры " + name + "\n";
                    count++;
                }
            }
            else if (textBoxConsoleInput.Text[0] == 'D')
            {
                string name = Convert.ToString(operands.Pop().value);
                Figure figure = ShapeContainer.FindFigure(name);
                if (FindName(name) == name)
                {
                    DeleteName(name);
                    this.figure.DeleteF(figure);
                    richTextBoxCommandHistory.Text += "[" + count + "]: " + "Фигура " + name + " была удалена\n";
                    comboBoxFigureList.Items.Remove(name);
                    count++;
                }
                else
                {
                    MessageBox.Show("Фигуры с именем " + name + " не существует", "Сообщение");
                    richTextBoxCommandHistory.Text += "[" + count + "]: " + "Попытка удаления по несуществующему имени " + name + "\n";
                    count++;
                }
            }
            else if (textBoxConsoleInput.Text[0] == 'M')
            {
                int x, y;
                string name;            
                //MessageBox.Show(Convert.ToString(operands.Peek().value));
                y = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                //MessageBox.Show(Convert.ToString(operands.Peek().value));
                x = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                name = Convert.ToString(operands.Pop().value);
                if (FindName(name) == name) 
                { 
                    figure = ShapeContainer.FindFigure(name);
                    figure.MoveTo(x, y);
                    richTextBoxCommandHistory.Text += "[" + count + "]: " + "Фигура " + name + " была перемещена на " + x + " по X и на " + y + " по Y\n";
                    count++;
                }
                else
                {
                    MessageBox.Show("Фигуры с именем " + name + " не существует", "Сообщение");
                    richTextBoxCommandHistory.Text += "[" + count + "]: " + "Попытка перемещения по несуществующему имени " + name + "\n";
                    count++;
                }
            }
            else if (textBoxConsoleInput.Text == "clear")
            {
                foreach (Figure figure in ShapeContainer.figureList)
                {
                    figure.Clear();
                    names.Remove(FindName(figure.name));
                    comboBoxFigureList.Items.Clear();
                    pictureBox1.Image = null;
                    richTextBoxCommandHistory.Text += "[" + count + "]: " + "Очищено\n";
                }
            }
            else
            {
                MessageBox.Show("Введенной операции не существует");
                richTextBoxCommandHistory.Text += "[" + count + "]: " + "Попытка использования несуществующей операции " + op.symbolOperator + "\n";
                count++;
            }
        }
        public string randomName()
        {
            string name = null;
            Random random = new Random();
            char a = Convert.ToChar(random.Next(67, 90));
            name += a;
            name = name.ToLower();
            return name;
        }
        public int randomNumber(bool trg = true)
        {
            if (trg)
            {
                int num = 0;
                Random random = new Random();
                num = random.Next(40, 150);
                return num;
            }
            else
            {
                int num = 0;
                Random random = new Random();
                num = random.Next(11, 26);
                return num;
            }
        }
        
        private void textBoxConsoleInput_TextChanged(object sender, EventArgs e)
        {
            if (pressBack)
            {
                if (textBoxConsoleInput.Text != null)
                {
                    if (textBoxConsoleInput.Text[0] == 'E')
                    {
                        textBoxAutoFilling.Show();
                        textBoxAutoFilling.Text = "E(" + randomName() + "," + randomNumber() + "," + randomNumber() + "," + randomNumber() + "," + randomNumber() + ")";
                    }
                    else if (textBoxConsoleInput.Text[0] == 'D')
                    {
                        textBoxAutoFilling.Show();
                        textBoxAutoFilling.Text = "D(" + lastName + ")";
                    }
                    else if (textBoxConsoleInput.Text[0] == 'M')
                    {
                        textBoxAutoFilling.Show();
                        textBoxAutoFilling.Text = "M(" + lastName + "," + randomNumber(false) + "," + randomNumber(false) +")";
                    }
                    else if (textBoxConsoleInput.Text[0] != ' ')
                    {
                        textBoxAutoFilling.Hide();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public bool pressBack = true;
        private void textBoxConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxConsoleInput.Text != "clear")
            {
                if (e.KeyCode == Keys.Back)
                {
                    pressBack = false;
                    textBoxAutoFilling.Visible = false;
                }
                else if (textBoxConsoleInput.Text != null)
                {
                    pressBack = true;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        bool flag = true;
                        for (int i = 0; i < textBoxConsoleInput.Text.Length; i++)
                        {

                            if (IsNotOperation(textBoxConsoleInput.Text[i]))
                            {
                                if (!(Char.IsDigit(textBoxConsoleInput.Text[i])))
                                {
                                    this.operands.Push(new Operand(textBoxConsoleInput.Text[i]));
                                    continue;
                                }
                                else
                                    if (Char.IsDigit(textBoxConsoleInput.Text[i]))
                                    {
                                        if (Char.IsDigit(textBoxConsoleInput.Text[i + 1]))
                                        {


                                            if (flag)
                                            {

                                                this.operands.Push(new Operand(textBoxConsoleInput.Text[i]));
                                            }

                                            this.operands.Push(new Operand(Convert.ToInt32(Convert.ToString(this.operands.Pop().value)) * 10 + Convert.ToInt32(Convert.ToString(textBoxConsoleInput.Text[i + 1]))));
                                            flag = false;
                                            continue;
                                        }
                                        else
                                            if ((textBoxConsoleInput.Text[i + 1] == ',' || textBoxConsoleInput.Text[i + 1] == ')') && !(Char.IsDigit(textBoxConsoleInput.Text[i - 1])))
                                            {
                                                this.operands.Push(new Operand(Convert.ToInt32(textBoxConsoleInput.Text[i])));
                                                continue;
                                            }
                                        flag = true;
                                    }

                            }
                            else
                                if (textBoxConsoleInput.Text[i] == 'E')
                                {
                                    this.operators.Push(OperatorContainer.FindOperator(textBoxConsoleInput.Text[i]));
                                }
                                else
                                    if (textBoxConsoleInput.Text[i] == 'M')
                                    {
                                        if (this.operators.Count != 0)
                                        {
                                            this.operators.Push(OperatorContainer.FindOperator(textBoxConsoleInput.Text[i]));
                                        }
                                    }
                                    else
                                        if (textBoxConsoleInput.Text[i] == 'D')
                                        {
                                            if (this.operators.Count != 0)
                                            {
                                                this.operators.Push(OperatorContainer.FindOperator(textBoxConsoleInput.Text[i]));
                                            }
                                        }
                                        else
                                            if (textBoxConsoleInput.Text[i] == '(')
                                            {
                                                this.operators.Push(OperatorContainer.FindOperator(textBoxConsoleInput.Text[i]));
                                            }
                                            else
                                                if (textBoxConsoleInput.Text[i] == ')')
                                                {
                                                    do
                                                    {
                                                        if (operators.Peek().symbolOperator == '(')
                                                        {
                                                            operators.Pop();
                                                            break;
                                                        }
                                                        if (operators.Count == 0)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    while (operators.Peek().symbolOperator != '(');

                                                }
                        }
                        if (operators.Peek() != null)
                        {
                            operands.Pop();
                            SelectingPerformingOperation(operators.Peek());
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Введенная команда некорректна");
                        richTextBoxCommandHistory.Text += "[" + count + "]: " + "Попытка ввода некорректной команды " + textBoxConsoleInput.Text + "\n";
                        count++;
                    }

                }
                
            }
            else if (textBoxConsoleInput.Text == "clear")
            {
                SelectingPerformingOperation(operators.Peek());
            }
            if (e.KeyCode == Keys.F9)
            {
                Help help = new Help();
                help.Show();
            }
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public bool trg = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (trg == false) 
            {
                richTextBoxCommandHistory.Visible = true;
                trg = true;
            }
            else if (trg == true)
            {
                richTextBoxCommandHistory.Visible = false;
                trg = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBoxAutoFilling_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAutoFilling_Click(object sender, EventArgs e)
        {
            textBoxConsoleInput.Text = textBoxAutoFilling.Text;
            textBoxAutoFilling.Hide();
        }
    }
}
