using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTOOL
{
    public static class GenClass
    {
        
            public static string[] ToGenerate(RichTextBox inputCC,int amount,string year,string month,string cvv)
            {

           
            Random random = new Random();
            string _year = year;
            string _month = month;
            string _cvv = cvv;
            string[] result = new string[inputCC.Lines.Length*amount];
            int counter = 0;
            int index = 0;
            bool isMonthRandom = false;
            bool isYearRandom = false;
            bool isCVVRandom = false;


            if (_month.Equals("Random"))
            {
                isMonthRandom = true;
            }

      
            if (_year.Equals("Random"))
            {
                isYearRandom = true;
            }

            if (String.IsNullOrEmpty(_cvv))
            {
                isCVVRandom = true;
            }

            foreach (string _initcard in inputCC.Lines)
                    {

                string card = string.Empty;
                counter = 0;
                while (counter < amount)
                {
                    

                    card = _initcard;/*new string(_initcard.Where(x=>char.IsDigit(x)).ToArray());*/

                    if (!_initcard.Contains('x') && _initcard.Length > 11)
                    {
                        card = _initcard.Substring(0, 11);
                    }


                    if (card.Contains('x'))
                    {

                        foreach (char x in card.ToCharArray())
                        {

                            Random randomNum = new Random();
                            int _randomNum = randomNum.Next(0, 9);
                            if (x.Equals('x'))
                            {

                                char replace = Convert.ToChar(Convert.ToString(_randomNum));
                                int _xIndex = card.IndexOf(x);
                                card = card.ReplaceAt(_xIndex, replace);

                            }
                        }
                    }

                    if (card.Length < 16)
                    {

                        while (card.Length < 16)
                        {

                            Random random2 = new Random();
                            int _randomNum2 = random2.Next(0, 9);
                            card += String.Format("{0}", _randomNum2);


                        }
                    }


                    if (isMonthRandom)
                    {

                        Random randomMonth = new Random();
                        int _randomMonth = randomMonth.Next(1, 12);
                        string ranMonth = string.Format("{0:00}", _randomMonth);
                        _month = ranMonth;
                    }

                    else
                    {
                        int specMonth = listMonth().IndexOf(month);
                        _month = string.Format("{0:00}", specMonth);
                    }

                    if (isYearRandom)
                    {

                        Random randomYear = new Random();
                        int _randomYear = randomYear.Next(23, 30);
                        string ranYear = string.Format("20{0:00}", _randomYear);
                        _year = ranYear;
                    }

                    if (isCVVRandom)
                    {

                        Random randomCvv = new Random();
                        int _randomCvv = randomCvv.Next(0, 999);
                        string ranCvv = string.Format("{0:000}", _randomCvv);
                        _cvv = ranCvv;
                    }

                    if (LuhnCheck(card))
                    {
                        index++;
                        result[index - 1] = string.Format(card + "|{0}|{1}|{2}", _month, _year, _cvv);
                        counter++;
                    }
                }

                }
            return result;
            }
        public static string ReplaceAt(this string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
        
        public static List <string> listMonth()
        {
            List<string> year = new List<string>();
            year.Add("Random");
            year.Add("January");
            year.Add("February");
            year.Add("March");
            year.Add("April");
            year.Add("May");
            year.Add("June");
            year.Add("July");
            year.Add("August");
            year.Add("September");
            year.Add("October");
            year.Add("November");
            year.Add("December");
            return year;
        }

        public static List<string> listYear()
        {
            List<string> year = new List<string>();

            year.Add("Random");
            year.Add("2023");
            year.Add("2024");
            year.Add("2025");
            year.Add("2026");
            year.Add("2027");
            year.Add("2028");
            year.Add("2029");
            year.Add("2030");
        
            return year;
        }

        public static bool LuhnCheck(string cardnum)
        {
            string number = cardnum;
            char[] chars = number.ToCharArray();
            int sumof2 = 0;
            int sumof1 = 0;
            int sumofall = 0;
            string sumofmultiple2 = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {

                if (i % 2 != 0)
                {
                    sumof1 += Convert.ToInt32(chars[i].ToString());
                }
                else
                {
                    int num = Convert.ToInt32(chars[i].ToString()) * 2;
                    sumofmultiple2 = num.ToString();
                    if (sumofmultiple2.Length > 1)
                    {
                        int a = Convert.ToInt32(sumofmultiple2[0].ToString());
                        int b = Convert.ToInt32(sumofmultiple2[1].ToString());
                        int c = a + b;
                        sumof2 += c;
                    }
                    else
                    {
                        sumof2 += num;
                    }
                }
            }
            
            return (sumof1 + sumof2) % 10 == 0;
        }

    }
}
