using System;

namespace CreditCardChecker
{
    public class CreditCardChecker
    {
        /// <summary>
        /// Diese Methode überprüft eine Kreditkartenummer, ob diese gültig ist.
        /// Regeln entsprechend der Angabe.
        /// </summary>
        public static bool IsCreditCardValid(string creditCardNumber)
        {
            int length = creditCardNumber.Length;
           if(length == 16)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Berechnet aus der Summe der geraden Stellen (bereits verdoppelt) und
        /// der Summe der ungeraden Stellen die Checkziffer.
        /// </summary>
        private static int CalculateCheckDigit(int oddSum, int evenSum)
        {

            /*  for (int i = 0; i < 16; i++)
              {
                  if (i % 2 == 0)
                  {
                      var newi = i* 2;
                      var ziffernsumme = newi + newi;
                      ziffernsumme += 1;



                  }
                  else
                  {
                      var ni  =  i ++;

                  }

                  */
            var sum = oddSum + evenSum;

            return sum;
           
        }

        /// <summary>
        /// Berechnet die Ziffernsumme einer Zahl.
        /// </summary>
        private static int CalculateDigitSum(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                var n = number % 10;
                sum = sum + n;
                number = number / 10;

            }
            return sum;
            
        }

        private static int ConvertToInt(char ch)
        {
            var c = Int32.Parse(ch.ToString());
            return c;
        }


    }
}
