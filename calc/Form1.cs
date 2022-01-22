using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace calc
{
    public partial class Form1 : Form
    {
        List<int> FirstNumber = new List<int>();    //список для хранения первого числа
        List<int> SecondNumber = new List<int>();   //список для хранения второго числа
        List<int> Answer = new List<int>();         //список для хранения ответа
        List<string> textbox = new List<string>(); //список для хранения строк, которые выводятся в поле ответа
        int position;                               //нужна для выбора предыдущих значений (номер строки, на которой будет стоять *)
        bool checkoperations = false;               //Флаг для операций
        char Znak = ' ';                            //переменная для хранения знака
        bool ravn = false;                          //флаг для определения была ли нажата кнопка "="

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textanswer.BackColor = Color.White;
            textanswer.Text = "0";
            kostyl.TabIndex = 0; //устанавливает начальный фокус на скрытый элемент
            kostyl.Focus(); //переводит фокус на скрытый элемент
        }

        //обработчики для кнопок на клавиатуре
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D0:
                    button_number('0');
                    break;
                case Keys.D1:
                    button_number('1');
                    break;
                case Keys.D2:
                    button_number('2');
                    break;
                case Keys.D3:
                    button_number('3');
                    break;
                case Keys.D4:
                    button_number('4');
                    break;
                case Keys.D5:
                    button_number('5');
                    break;
                case Keys.D6:
                    button_number('6');
                    break;
                case Keys.D7:
                    button_number('7');
                    break;
                case Keys.D8:
                    button_number('8');
                    break;
                case Keys.D9:
                    button_number('9');
                    break;
                case Keys.Back:
                    L_btn();
                    break;
                case Keys.U:
                    operations('+');
                    break;
                case Keys.I:
                    operations('-');
                    break;
                case Keys.O:
                    operations('*');
                    break;
                case Keys.P:
                    operations('/');
                    break;
                case Keys.Enter:
                    Answer_btn();
                    break;
                case Keys.Tab:
                    Plusminus_btn();
                    break;
                case Keys.E:
                    Ce_btn();
                    break;
                case Keys.C:
                    C_btn();
                    break;
                case Keys.Up:
                    up_btn();
                    break;
                case Keys.Down:
                    down_btn();
                    break;
                case Keys.NumPad0:
                    button_number('0');
                    break;
                case Keys.NumPad1:
                    button_number('1');
                    break;
                case Keys.NumPad2:
                    button_number('2');
                    break;
                case Keys.NumPad3:
                    button_number('3');
                    break;
                case Keys.NumPad4:
                    button_number('4');
                    break;
                case Keys.NumPad5:
                    button_number('5');
                    break;
                case Keys.NumPad6:
                    button_number('6');
                    break;
                case Keys.NumPad7:
                    button_number('7');
                    break;
                case Keys.NumPad8:
                    button_number('8');
                    break;
                case Keys.NumPad9:
                    button_number('0');
                    break;
                case Keys.Divide:
                    operations('/');
                    break;
                case Keys.Multiply:
                    operations('*');
                    break;
                case Keys.Subtract:
                    operations('-');
                    break;
                case Keys.Add:
                    operations('+');
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region служебные

        //преобразует строку в список "цифр"
        private List<int> StringToList(string number)
        {
            List<int> listnumber = new List<int>();
            for (int i = 0; i < number.Length; i++)
            {
                if((number[i] == '-') && (i == 0))
                {
                    listnumber.Add(-1);
                }
                else
                    listnumber.Add((int)Char.GetNumericValue(number[i]));
            }
            return listnumber;
        }

        //преобразует список "цифр" в строку
        private String ListToString(List<int> listnumber)
        {
            bool flag = false; 
            string number = "";
            for (int i = 0; i < listnumber.Count; i++)
            {
                if(listnumber[i] == -1 && i == 0)
                {
                    number += '-';
                }
                else if (listnumber[i] == -1 && i != 0)
                {
                    number += '(';
                    flag = true;
                }
                else
                    number += listnumber[i].ToString();
            }
            if (flag) number += ')';
            return number;
        }

        //Удаляет остаток из списка для вывода в поле ввода
        private String DeleteOstatok(String number)
        {
            if (number[number.Length-1] == ')')
            {
                for(int i = number.Length - 1; i >= 0; i--)
                {
                    if(number[i] == '(')
                    {
                        number = number.Substring(0, i);
                        break;
                    }
                }
            }
            return number;
        }

        //заменяет первый ноль на цифру. Нужно, чтобы не приходилось стирать ноль из поля ввода
        private void replace_zero(char repcif)
        {
            
            if (textanswer.Text.Length != 0)
            {
                if (textanswer.Text[0] == '0')
                {
                    textanswer.Text = textanswer.Text.Replace('0', repcif);
                }
                else
                {
                    textanswer.AppendText(repcif.ToString());
                }
            }
            else
            {
                textanswer.AppendText(repcif.ToString());
            }
        }

        //проверяет было ли нажатие на кнопку "="
        private void find_ravn()
        {
            if (ravn)
            {
                textanswer.Text = "0";
                ravn = false;
            }
        }

        //переводит фокус при клике на поле ввода. Нужно, чтобы не было возможности ввести символы с клавиатуры
        private void textanswer_MouseClick(object sender, MouseEventArgs e)
        {
            kostyl.Focus();
        }

        //переводит фокус при клике на поле ответа. Нужно, чтобы не было возможности ввести символы с клавиатуры
        private void Mem_MouseClick(object sender, MouseEventArgs e)
        {
            kostyl.Focus();
        }

        //обновляет информацию в поле ответа
        private void LoadTextBox()
        {
            Mem.Focus();
            Mem.Text = "";
            for(int i = 0; i < textbox.Count; i++)
            {
                Mem.AppendText(textbox[i]);
            }
            kostyl.Focus();
        }

        #endregion

        #region КНОПЫ 

        //кнопки с цифрами. Добавляют в поле ввода цифру.
        #region ЦИФРЫ
        
        //кнопка 0
        private void b0_Click(object sender, EventArgs e)
        {
            button_number('0');
        }
        //кнопка 1
        private void b1_Click(object sender, EventArgs e)
        {
            button_number('1');
        }
        //кнопка 2
        private void b2_Click(object sender, EventArgs e)
        {
            button_number('2');
        }
        //кнопка 3
        private void b3_Click(object sender, EventArgs e)
        {
            button_number('3');
        }
        //кнопка 4
        private void b4_Click(object sender, EventArgs e)
        {
            button_number('4');
        }
        //кнопка 5
        private void b5_Click(object sender, EventArgs e)
        {
            button_number('5');
        }
        //кнопка 6
        private void b6_Click(object sender, EventArgs e)
        {
            button_number('6');
        }
        //кнопка 7
        private void b7_Click(object sender, EventArgs e)
        {
            button_number('7');
        }
        //кнопка 8
        private void b8_Click(object sender, EventArgs e)
        {
            button_number('8');
        }
        //кнопка 9
        private void b9_Click(object sender, EventArgs e)
        {
            button_number('9');
        }
        #endregion

        //кнопки с операциями (+ - * /)
        #region ОПЕРАЦИИ

        //кнопка "-"
        private void minus_Click(object sender, EventArgs e)
        {
            operations('-');
        }
        //кнопка "+"
        private void plusic_Click(object sender, EventArgs e)
        {
            operations('+');
        }
        //кнопка "*"
        private void ymn_Click(object sender, EventArgs e)
        {
            operations('*');
        }
        //кнопка "/"
        private void razd_Click(object sender, EventArgs e)
        {
            operations('/');
        }

        #endregion
        
        //остальные кнопки
        #region допкнопы
        
        //удаляет одну цифру с конца
        private void left_Click(object sender, EventArgs e)
        {
            L_btn();
        }

        //кнопка "="
        private void answer_Click(object sender, EventArgs e)
        {
            Answer_btn();
        }

        //меняет знак числа
        private void plusminus_Click(object sender, EventArgs e)
        {
            Plusminus_btn();
        }

        //полностью очищает память и поле ввода
        private void c_Click(object sender, EventArgs e)
        {
            C_btn();
        }

        //очищает поле ввода
        private void ce_Click(object sender, EventArgs e)
        {
            Ce_btn();
        }

        //стрелка вверх
        private void up_Click(object sender, EventArgs e)
        {
            up_btn();
        }
        //стрелка вниз
        private void down_Click(object sender, EventArgs e)
        {
            down_btn();
        }

        #endregion

        #endregion

        #region логика для кнопок


        //кнопка стрелка вверх
        private void up_btn()
        {
            if(position + 1 >= 4)
            {
                string buffer;
                position -= 4;
                Mem.Text = "";
                for (int i = 0; i < position+1; i++)//выводит текст до позиции
                {
                    Mem.AppendText(textbox[i]);
                }
                Mem.Focus();
                Mem.AppendText(textbox[position + 1] + "   (*)"); //добавляет строку "со звёздочкой"
                buffer = DeleteOstatok(textbox[position + 1]);
                if (buffer != "еггог")
                    textanswer.Text = buffer;
                else
                    textanswer.Text = "0";

                kostyl.Focus();
                for (int i = position + 2; i < textbox.Count; i++) //выводит текст после позиции
                {
                    Mem.AppendText(textbox[i]);
                }
            }
        }

        //кнопка стрелка ввниз
        private void down_btn()
        {
            if (position + 4 + 1 < textbox.Count)
            {
                string buffer;
                position += 4;
                Mem.Text = "";
                for (int i = 0; i < position + 1; i++) //выводит текст до позиции
                {
                    Mem.AppendText(textbox[i]);
                }
                Mem.Focus();
                Mem.AppendText(textbox[position + 1] + "   (*)");//добавляет строку "со звёздочкой"
                buffer = DeleteOstatok(textbox[position + 1]);
                if (buffer != "еггог")
                    textanswer.Text = buffer;
                else
                    textanswer.Text = "0";
                kostyl.Focus();
                for (int i = position + 2; i < textbox.Count; i++)//выводит текст после позиции
                {
                    Mem.AppendText(textbox[i]);
                }
            }
        }

        //выводит на экран цифру
        private void button_number(char cif)
        {
            find_ravn();
            replace_zero(cif);
        }

        //+ - * /
        private void operations(char cif)
        {
            if (!checkoperations) // если кнопка с операцией не была нажата
            {
                textbox.Add(textanswer.Text);
                textbox.Add("\n");
                textbox.Add(cif.ToString());
                textbox.Add("\n");
                FirstNumber.Clear();
                FirstNumber = StringToList(textanswer.Text);
            }
            else
            {
                textbox[textbox.Count - 2] = cif.ToString(); //заменяет знак
            }
            LoadTextBox(); //обновление информации в поле ответа
            textanswer.Text = "0";
            Znak = cif;
            checkoperations = true; //кнопка с операцией нажата
            position = textbox.Count - 1;
        }

        //удаляет последний символ в поле ввода
        private void L_btn()
        {
            if (textanswer.Text != "" && textanswer.Text != "0") //если в поле нет символов и нет 0
                if (textanswer.Text.Length != 1) 
                {
                    textanswer.Text = textanswer.Text.Remove(textanswer.Text.Length - 1, 1); //удалить последний символ
                }
                else
                {
                    textanswer.Text = textanswer.Text.Remove(textanswer.Text.Length - 1, 1); //удалить последний символ
                    textanswer.AppendText("0"); //добавить ноль
                }
        }

        //кнопка ответа
        private void Answer_btn()
        {
            SecondNumber.Clear(); //очищает строку для хранения второго числа
            SecondNumber = StringToList(textanswer.Text); //записывает в эту строку число из поля ввода
            if (FirstNumber.Count == 0) FirstNumber.Add(0);
            if (SecondNumber.Count == 0) SecondNumber.Add(0);
            if (checkoperations) //если была операция
            {
                textbox.Add(textanswer.Text); 
                textbox.Add("\n");
                textbox.Add("=");
                textbox.Add("\n");
            }
            textanswer.Text = "";
            Answer = Calc.Calculate(FirstNumber, SecondNumber, Znak); //вычисление 

            textanswer.AppendText("0"); //в поле ввода добавляется ноль

            if (checkoperations)
            {
                if (Answer.Count > 1 && Answer[1] == 88) //если ошибка
                {
                    textbox.Add("еггог");
                }
                else
                {
                    textbox.Add(ListToString(Answer));
                }
                textbox.Add("\n");
                textbox.Add("_______________");
                textbox.Add("\n");
            }
            LoadTextBox(); //обновление информации в поле ответа
            Znak = ' ';
            checkoperations = false; 
            ravn = true;
            position = textbox.Count - 1;
        }

        //меняет знак числа
        private void Plusminus_btn()
        {
            if (textanswer.Text.Length != 0 && textanswer.Text != "0")
            {
                if (textanswer.Text[0] == '-') //если нулевой символ в строке минус
                {
                    textanswer.Text = textanswer.Text.Remove(0, 1); //удаляет минус
                }
                else
                {
                    textanswer.Text = textanswer.Text.Insert(0, "-"); //добавляет минус
                }
            }
        }

        //очищает память 
        private void C_btn()
        {
            if (checkoperations)
            {
                for (int i = 0; i < 4; i++)
                {
                    textbox.RemoveAt(textbox.Count - 1);
                }
            }
            checkoperations = false;
            FirstNumber.Clear();
            SecondNumber.Clear();
            textanswer.Text = "0";
            textbox.Clear();
            LoadTextBox();
        }

        //Очищает поле ввода
        private void Ce_btn() 
        {
            textanswer.Text = "0";
        }

        #endregion


    }
}
