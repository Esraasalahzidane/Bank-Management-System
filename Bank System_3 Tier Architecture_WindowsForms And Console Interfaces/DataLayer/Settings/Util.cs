namespace DataLayer.Settings
{
    public class Util
    {
        static char encryptTextMethod(char textChar, short encryptionKey) => (char)((int)(textChar) + encryptionKey);
        static char decryptTextMethod(char decryptedChar, short encryptionKey) => (char)((int)(decryptedChar) - encryptionKey);
        public static string encryptText(string text)
        {
            string encryptText = "";

            for (int i = 0; i < text.Length; i++)
                encryptText += encryptTextMethod(text[i], 2);

            return encryptText;
        }
        public static string decryptText(string decryptionText)
        {
            string dencryptText = "";

            for (int i = 0; i < decryptionText.Length; i++)
                dencryptText += decryptTextMethod(decryptionText[i], 2);

            return dencryptText;
        }
        public static string NumberToText(int Number)
        {

            if (Number == 0)
            {
                return "";
            }

            if (Number >= 1 && Number <= 19)
            {
                string[] arr = { "", "One","Two","Three","Four","Five","Six","Seven",
                                              "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen",
                                               "Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
                return arr[Number] + " ";
            }

            if (Number >= 20 && Number <= 99)
            {
                string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                return arr[Number / 10] + " " + NumberToText(Number % 10);
            }

            if (Number >= 100 && Number <= 199)
            {
                return "One Hundred " + NumberToText(Number % 100);
            }

            if (Number >= 200 && Number <= 999)
            {
                return NumberToText(Number / 100) + "Hundreds " + NumberToText(Number % 100);
            }

            if (Number >= 1000 && Number <= 1999)
            {
                return "One Thousand " + NumberToText(Number % 1000);
            }

            if (Number >= 2000 && Number <= 999999)
            {
                return NumberToText(Number / 1000) + "Thousands " + NumberToText(Number % 1000);
            }

            if (Number >= 1000000 && Number <= 1999999)
            {
                return "One Million " + NumberToText(Number % 1000000);
            }

            if (Number >= 2000000 && Number <= 999999999)
            {
                return NumberToText(Number / 1000000) + "Millions " + NumberToText(Number % 1000000);
            }

            if (Number >= 1000000000 && Number <= 1999999999)
            {
                return "One Billion " + NumberToText(Number % 1000000000);
            }
            else
            {
                return NumberToText(Number / 1000000000) + "Billions " + NumberToText(Number % 1000000000);
            }
        }
    }
}
