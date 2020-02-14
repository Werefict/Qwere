using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VIN_LIB
{
    public class Class1
    {
        public static bool CheckVIN(string vin)
        {
            string pattern = @"^[0-9A-HJ-NPR-Z]$";
            Regex regex = new Regex(pattern);
            return false;
        }

        public string GetVINCountry(string vin)
        {
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("AA-AH", "ЮАР");
            country.Add("AJ-AN", "Кот-дИвуар");
            country.Add("AP-A0", "не используется");
            country.Add("BA-BE", "Ангола");
            country.Add("BF-BK", "Кения");
            country.Add("BL-BR", "Танзания");
            country.Add("BS-B0", "не используется");
            country.Add("CA-CE", "Бенин");
            country.Add("CF-CK", "Мадагаскар");
            country.Add("CL-CR", "Тунис");
            country.Add("CS-C0", "не используется");
            country.Add("DA-DE", "Египет");
            country.Add("DF-DK", "Марокко");
            country.Add("DL-DR", "Замбия");
            country.Add("DS-D0", "не используется");
            country.Add("EA-EE", "Эфиопия");
            country.Add("EF-EK", "Мозамбик");
            country.Add("EL-E0", "не используется");
            country.Add("FA-FE", "Гана");
            country.Add("FF-FK", "Нигерия");
            country.Add("FL-F0", "не используется");
            country.Add("GA-G0", "не используется");
            country.Add("HA-H0", "не используется");

            country.Add("JA-JT", "ЮАР");
            country.Add("KA-KE", "ЮАР");
            country.Add("KF-KK", "ЮАР");
            country.Add("KL-KR", "ЮАР");
            country.Add("KS-K0", "ЮАР");
            country.Add("LA-L0", "ЮАР");
            country.Add("MA-ME", "ЮАР");
            country.Add("MF-MK", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            country.Add("AA-AH", "ЮАР");
            return "";
        }

        public int GetTransportYear(string vin)
        {
            return 0;
        }
    }
}
