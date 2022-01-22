using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public static class Calc
    {
        #region ОПЕРАЦИИ

        //сложение
        private static List<int> Summ(List<int> FirstNumber, List<int> SecondNumber)
        {
            
            int summa;
            int buffer = 0;
            
            if (FirstNumber.Count > SecondNumber.Count) //уравниваем длину списков, для удобства
            {
                while (FirstNumber.Count != SecondNumber.Count)
                    SecondNumber.Insert(0,0);
            }
            else if (FirstNumber.Count < SecondNumber.Count)
            {
                while (FirstNumber.Count != SecondNumber.Count)
                    FirstNumber.Insert(0, 0);
            }

            List<int> Answer = new List<int>(); //выделяем память для списка результатов
            for (int i = FirstNumber.Count-1; i >= 0; i--) //сложение
            {
                if (buffer != 0)//если в предыдущем сложении не было запоминания
                {
                    summa = FirstNumber[i] + SecondNumber[i] + buffer; //сложение 2 цифр + то, что запомнили
                    buffer = 0;
                }
                else
                {
                    summa = FirstNumber[i] + SecondNumber[i]; //сложение 2 цифр
                }

                if (summa >= 10) //если запоминание 
                {
                    buffer = summa / 10; //запоминаем целую часть
                    Answer.Insert(0, summa % 10); //остаток в ответ
                }
                else
                {
                    Answer.Insert(0,summa); //запоминания нет, записывает результат сложения
                }
                if (i == 0 && buffer != 0)//если последняя цифра, но было запоминание
                    Answer.Insert(0,buffer);
            }
            return Answer;
        }

        //вычитание
        private static List<int> Minus(List<int> FirstNumber, List<int> SecondNumber)
        {
            int buffer = 0;
            bool minus = false; //флаг для минуса
            if (FirstNumber.Count > SecondNumber.Count) //если первое число больше второго
            {
                while (FirstNumber.Count != SecondNumber.Count) //уравниваем длину списков, для удобства
                {
                    SecondNumber.Insert(0, 0);
                }
            }
            else if (FirstNumber.Count < SecondNumber.Count) //если первое число меньше второго, то меняем их местами
            {
                while (FirstNumber.Count != SecondNumber.Count)
                    FirstNumber.Insert(0, 0);
                List<int> buff = new List<int>();
                buff = SecondNumber;
                SecondNumber = FirstNumber;
                FirstNumber = buff;
                minus = true; //поднимаем флаг минус
            }
            else if (FirstNumber.Count == SecondNumber.Count) //если количество цифр в числах одинаковое
            {
                if (BolMen(FirstNumber, SecondNumber) == 2)//если второе число больше первого, то меняем их местами 
                {
                    List<int> buff = new List<int>();
                    buff = SecondNumber;
                    SecondNumber = FirstNumber;
                    FirstNumber = buff;
                    minus = true; //поднимаем флаг минус
                }
            }

            List<int> Answer = new List<int>(); //выделяем память для списка результатов
            for (int i = FirstNumber.Count - 1; i >= 0; i--) //вычитание
            {
                if (buffer == 0) //в предыдущем действии не занимали единицу из старшего разряда
                {
                    if (FirstNumber[i] - SecondNumber[i] >= 0)//если цифра первого числа больше цифры второго
                    {
                        Answer.Insert(0, FirstNumber[i] - SecondNumber[i]); //вычитаем
                        buffer = 0;
                        continue;
                    }
                    else // если меньше
                    {
                        Answer.Insert(0, 10 + FirstNumber[i] - SecondNumber[i]);//цифра первого числа + 10 - цифра второго
                        buffer = 1; //запоминаем 1
                        continue;
                    }
                }
                else //если занимали
                {
                    if (FirstNumber[i] - SecondNumber[i] - 1 >= 0) //если цифра первого числа больше цифры второго - 1
                    {
                        Answer.Insert(0, FirstNumber[i] - SecondNumber[i] - 1); //дополнительно вычитаем единицу
                        buffer = 0;
                        continue;
                    }
                    else
                    {
                        Answer.Insert(0, 10 + FirstNumber[i] - SecondNumber[i] - 1); //цифра первого числа + 10 - цифра второго - 1
                        buffer = 1; //запоминаем 1
                        continue;
                    }
                }
            }
            if (minus) 
                Answer.Insert(0, -1); //добавляем минус 

            return Answer;
        }

        //умножение
        private static List<int> Ymn(List<int> FirstNumber, List<int> SecondNumber)
        {
            List<List<int>> AlmostAnswer = new List<List<int>>(); //список для хранения всех слагаемых 
            for (int i = FirstNumber.Count - 1; i >= 0; i--) //цикл по длине списка первого числа
            {
                int memory = 0;
                List<int> PartOfAlmostAnswer = new List<int>(); //список для хранения слагаемого
                for (int j = SecondNumber.Count - 1; j >= 0; j--)//цикл по длине списка второго числа
                {
                    int buffer = FirstNumber[i] * SecondNumber[j]; //перемножение цифр
                    if (memory != 0)
                    {
                        if (buffer >= 10) //если запоминание 
                        {
                            PartOfAlmostAnswer.Insert(0, buffer % 10 + memory); //остаток + то, что запомнили
                            memory = buffer / 10; //запоминаем целую часть
                        }
                        else
                        {
                            PartOfAlmostAnswer.Insert(0, buffer + memory); //результат умножения + то, что запомнили
                            memory = 0; //ничего не запоминаем
                        }
                    }
                    else
                    {
                        if (buffer >= 10) //если запоминание 
                        {
                            PartOfAlmostAnswer.Insert(0, buffer % 10); //остаток 
                            memory = buffer / 10; //запоминаем целую часть
                        }
                        else
                        {
                            PartOfAlmostAnswer.Insert(0, buffer); //результат умножения
                            memory = 0; //ничего не запоминаем
                        }
                    }
                    if (j == 0 && memory != 0) //если последняя цифра, но было запоминание
                        PartOfAlmostAnswer.Insert(0, memory);
                }
                for (int k = 0; k < FirstNumber.Count - 1 - i; k++) // сдвигаем каждую сумму на разряд влево, добавляя нули в конец
                {
                    PartOfAlmostAnswer.Add(0);
                }

                AlmostAnswer.Add(PartOfAlmostAnswer); //добавляем сумму в список сумм
            }
            List<int> Answer = new List<int>(); //выделяем память для списка ответов
            Answer.Add(0); 
            for (int i = 0; i < AlmostAnswer.Count; i++) //складываем все числа из списка сумм с помощью метода сложения
            {
                Answer = Summ(Answer, AlmostAnswer[i]); 
            }
            return Answer;
        }
        //деление
        private static List<int> Delete(List<int> FirstNumber, List<int> SecondNumber)
        {
            List<int> Answer = new List<int>();

            int position;
            if (SecondNumber.Count == 1 && SecondNumber[0] == 0) //если деление на ноль
            {
                Answer.Add(88);
                Answer.Add(88);
                Answer.Add(88);
                return Answer;
            }
            if (BolMen(FirstNumber, SecondNumber) == 0) //если числа равны
            {
                Answer.Add(1);
                return Answer;
            }
            else if (BolMen(FirstNumber, SecondNumber) == 2) //если второе число больше первого
            {
                Answer.Add(88);
                Answer.Add(88);
                Answer.Add(88);
                return Answer;
            }
            List<int> memory = new List<int>(); //список для хранения части делимого
            for (int i = 0; i < SecondNumber.Count; i++) //цикл по длине делителя
            {
                memory.Add(FirstNumber[i]);//формируем часть делимого
            }
            position = memory.Count; //текущая позиция в делимом

            while (position - 1 != FirstNumber.Count)//пока позиция не достигнет конца
            {
                if(memory.Count <= SecondNumber.Count && BolMen(memory, SecondNumber) == 2) //если часть делимого меньше делителя
                {
                    Answer.Add(0);
                }
                else if (BolMen(memory, SecondNumber) == 0) //если равны
                {
                    Answer.Add(1);
                    memory.Clear();
                }
                else if (BolMen(memory, SecondNumber) == 1) //если часть делимого больше делителя
                {
                    int moment = 0; //переменная для хранения цифры ответа
                    while (BolMen(memory, SecondNumber) == 1 || BolMen(memory, SecondNumber) == 0)//пока делитель меньше или равен
                    {
                        memory = Minus(memory, SecondNumber);//вычитание
                        moment++;
                    }
                    Answer.Add(moment);//добавить цифру в ответ
                    memory = DeleteZero(memory);
                    SecondNumber = DeleteZero(SecondNumber);
                }
                if (position != FirstNumber.Count) 
                    memory.Add(FirstNumber[position]); //добавить следующую цифру из делимого в часть делимого
                memory = DeleteZero(memory); //удалить нули в начале части делимого
                position++; 
            }

            //вычисление остатка
            memory = Ymn(Answer, SecondNumber);
            memory = Minus(FirstNumber, memory);
            memory = DeleteZero(memory);

            if (memory[0] != 0) //если есть остаток
            {
                Answer.Add(-1); //добавить разделитель 
                Answer.AddRange(memory); // добавить остаток
            }

            return Answer;
        }

        #endregion

        #region дополнительно

        //проверяет наличие минуса
        private static bool CheckMinus(int number)
        {
            if (number == -1)
                return true;
            else
                return false;
        }

        //удаляет минус (нужно для вычислений)
        private static List<int> DeleteMinus(List<int> number)
        {
            number.RemoveAt(0);
            return number;
        }

        //возвращает 0, если числа равны
        //возвращает 1, если первое число больше
        //возвращает 2, если второе число больше
        private static int BolMen(List<int> FirstNumber, List<int> SecondNumber)
        {
            if (FirstNumber.Count > SecondNumber.Count)
                return 1;
            else if (FirstNumber.Count < SecondNumber.Count)
                return 2;
            else if (FirstNumber.Count == SecondNumber.Count)
            {
                for(int i = 0; i < FirstNumber.Count; i++)
                {
                    if (FirstNumber[i] > SecondNumber[i])
                        return 1;
                    else if (FirstNumber[i] < SecondNumber[i])
                        return 2;
                    else
                        continue;
                }
            }
            return 0;
        }

        //удаляет нули перед числом
        public static List<int> DeleteZero (List<int> Number)
        {
            if (Number.Count != 0 && Number[0] == -1)
            {
                int i = 1;
                while (Number[i] == 0)
                {
                    Number.RemoveAt(i);
                }
            }
            else if (Number.Count != 0 && Number[0] == 0)
            {
                int i = 0;
                while (Number.Count > 1 && Number[i] == 0)
                    {
                        Number.RemoveAt(i);
                    }
            }
            return Number;
        }

        #endregion

        //вычисление
        public static List<int> Calculate(List<int> FirstNumber, List<int> SecondNumber, char Znak)
        {
            List<int> Answer = new List<int>();
            switch (Znak)
            {
                case '+':
                    if (!CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // + + 
                    {
                        Answer = Summ(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // - -
                    {
                        DeleteMinus(FirstNumber);
                        DeleteMinus(SecondNumber);
                        Answer = Summ(FirstNumber, SecondNumber);
                        Answer.Insert(0, -1);
                        Answer = DeleteZero(Answer);
                    }
                    if (!CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // + -
                    {
                        DeleteMinus(SecondNumber);
                        Answer = Minus(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // - +
                    {
                        DeleteMinus(FirstNumber);
                        Answer = Minus(SecondNumber, FirstNumber);
                        Answer = DeleteZero(Answer);
                    }
                    break;
                case '-':
                    if (!CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // + + 
                    {
                        Answer = Minus(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // - -
                    {
                        DeleteMinus(FirstNumber);
                        DeleteMinus(SecondNumber);
                        Answer = Minus(SecondNumber, FirstNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (!CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // + -
                    {
                        DeleteMinus(SecondNumber);
                        Answer = Summ(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // - +
                    {
                        DeleteMinus(FirstNumber);
                        Answer = Summ(FirstNumber, SecondNumber);
                        Answer.Insert(0, -1);
                        Answer = DeleteZero(Answer);
                    }
                    break;
                case '*':
                    if (!CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // + + 
                    {
                        Answer = Ymn(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // - -
                    {
                        DeleteMinus(FirstNumber);
                        DeleteMinus(SecondNumber);
                        Answer = Ymn(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (!CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // + -
                    {
                        DeleteMinus(SecondNumber);
                        Answer = Ymn(FirstNumber, SecondNumber);
                        Answer.Insert(0, -1);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // - +
                    {
                        DeleteMinus(FirstNumber);
                        Answer = Ymn(FirstNumber, SecondNumber);
                        Answer.Insert(0, -1);
                        Answer = DeleteZero(Answer);
                    }
                    break;
                case '/':
                    if (!CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // + + 
                    {
                        Answer = Delete(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // - -
                    {
                        DeleteMinus(FirstNumber);
                        DeleteMinus(SecondNumber);
                        Answer = Delete(FirstNumber, SecondNumber);
                        Answer = DeleteZero(Answer);
                    }
                    if (!CheckMinus(FirstNumber[0]) && CheckMinus(SecondNumber[0])) // + -
                    {
                        DeleteMinus(SecondNumber);
                        Answer = Delete(FirstNumber, SecondNumber);
                        Answer.Insert(0, -1);
                        Answer = DeleteZero(Answer);
                    }
                    if (CheckMinus(FirstNumber[0]) && !CheckMinus(SecondNumber[0])) // - +
                    {
                        DeleteMinus(FirstNumber);
                        Answer = Delete(FirstNumber, SecondNumber);
                        Answer.Insert(0, -1);
                        Answer = DeleteZero(Answer);
                    }
                    break;
            }
            return Answer;
            
        }

    }
}
