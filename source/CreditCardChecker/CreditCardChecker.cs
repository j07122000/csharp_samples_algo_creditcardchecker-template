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
            int oddSum = 0;
            int evenSum = 0;
            int ziffernsumme = 0;
            int ni = 0;
            if (length == 16)
            {

                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 0)
                    {
                        var newi = i * 2;
                         ziffernsumme += newi + newi;
                        ziffernsumme += 1;
                        evenSum = ziffernsumme;

                    }
                    else
                    {
                        ni = i++;
                        oddSum += ni;

                    }

                    return true;
                }


     
            }
            return false;
        }

        /// <summary>
        /// Berechnet aus der Summe der geraden Stellen (bereits verdoppelt) und
        /// der Summe der ungeraden Stellen die Checkziffer.
        /// </summary>
        private static int CalculateCheckDigit(int oddSum, int evenSum)
        {

            /*   var gerade = CalculateDigitSum(oddSum);
               var ungerade = CalculateDigitSum(evenSum);

               gerade += 1;
               ungerade += 1;
               var sum = oddSum + evenSum;
               var einerstelle = sum % 10;
               if(sum > 10)

               return sum;
              */
            return oddSum + evenSum;
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
