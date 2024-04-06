using System.Text.RegularExpressions;
using ExceptionCpf;

namespace UtilCpf
{
    public class CpfUtil
    {
        private static bool IsCheckerDigitValid(string cpf, int endIndex)
        {
            string newCpf = cpf[..endIndex];

            int index = 0;

            IEnumerable<int> calcRange = Enumerable.Range(2, endIndex).Reverse();

            int totalSum = 0;

            int digit = 0;

            foreach (int time in calcRange)
            {
                digit = (int)Char.GetNumericValue(newCpf[index]);

                int multi = digit * time;

                totalSum += multi;

                index += 1;
            }

            int module = totalSum % 11;

            digit = 11 - module;

            int checkDigit = digit < 10 ? digit : 0;

            int currentDigit = (int)Char.GetNumericValue(cpf[endIndex]);

            return currentDigit == checkDigit;
        }

        private static void FirstCheckerDigit(string cpf)
        {
            if (!IsCheckerDigitValid(cpf, 9))
            {
                throw new CpfException("error: first checker digit cpf is invalid");
            }
        }

        private static void SecondCheckerDigit(string cpf)
        {
            if (!IsCheckerDigitValid(cpf, 10))
            {
                throw new CpfException("error: second checker digit cpf is invalid");
            }
        }

        private static void CpfRegexChecker(string cpf)
        {
            string cpfRegex = @"^[0-9]{11}$";

            if (!Regex.IsMatch(cpf, cpfRegex))
            {
                throw new CpfException("error: value for cpf is invalid - it must be numeric and length 11");
            }
        }

        public static void CpfChecker(string cpf)
        {
            CpfRegexChecker(cpf);

            FirstCheckerDigit(cpf);

            SecondCheckerDigit(cpf);
        }
    }
}