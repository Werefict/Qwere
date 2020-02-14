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

            country.Add("JA-JT", "Япония");
            country.Add("KA-KE", "Шри Ланка");
            country.Add("KF-KK", "Израиль");
            country.Add("KL-KR", "Южная Корея");
            country.Add("KS-K0", "Казахстан");
            country.Add("LA-L0", "Китай");
            country.Add("MA-ME", "Индия");
            country.Add("MF-MK", "Индонезия");
            country.Add("ML-MR", "Тайланд");
            country.Add("MS-M0", "не используется");
            country.Add("NK-NK", "Пакистан");
            country.Add("NL-NR", "Турция");
            country.Add("NT-N0", "не используется");
            country.Add("PA-PE", "Филиппины");
            country.Add("PF-PK", "Сингапур");
            country.Add("PL-PR", "Малайзия");
            country.Add("PS-P0", "не используется");
            country.Add("RA-RE", "ФОЭ");
            country.Add("RF-RK", "Тайвань");
            country.Add("RL-RR", "Въетнам");
            country.Add("RS-R0", "Саудовская Аравия");

            country.Add("SA-SM", "Великобритания");
            country.Add("SN-ST", "Германия");
            country.Add("SU-SZ", "Польша");
            country.Add("S1-S4", "Латвия");
            country.Add("TA-TH", "Швейцария");
            country.Add("TJ-TP", "Чехия");
            country.Add("TR-TV", "Венгрия");
            country.Add("TW-T1", "Португалия");
            country.Add("T2-T0", "не используется ");
            country.Add("UA-UG", "не используется ");
            country.Add("UH-UM", "Дания");
            country.Add("UN-UT", "Ирландия");
            country.Add("UU-UZ", "Румыния");
            country.Add("U1-U4", "не используется ");
            country.Add("U5-U7", "Словакия");
            country.Add("U8-U0", "не используется ");
            country.Add("VA-VE", "Австрия");
            country.Add("VF-VR", "Франция");
            country.Add("VS-VW", "Испания");
            country.Add("VX-V2", "Сербия");
            country.Add("V3-V5", "Хорватия");
            country.Add("V6-V0", "Эстония");
            country.Add("WA-W0", "германия");
            country.Add("XA-XE", "Болгария");
            country.Add("XF-XK", "Греция");
            country.Add("XL-XR", "Нидерланды");
            country.Add("XS-XW", "СССР/СНГ");
            country.Add("XX-X2", "Люксембург");
            country.Add("X3-X0", "Россия");
            country.Add("YA-YE", "Бельгия");
            country.Add("YF-YK", "Финляндия");
            country.Add("YL-YR", "Мальта");
            country.Add("YS-YW", "Швеция");
            country.Add("YX-Y2", "Норвегия");
            country.Add("Y3-Y5", "Беларусь");
            country.Add("Y6-Y0", "Украина");
            country.Add("ZA-ZR", "Италия");
            country.Add("ZS-ZW", "не используется ");
            country.Add("ZX-Z2", "Словения");
            country.Add("Z3-Z5", "Литва");
            country.Add("Z6-Z0", "Россия");

            country.Add("1A-10", "США");
            country.Add("2A-20", "Канада");
            country.Add("3A-3W", "Мексика");
            country.Add("3X-37", "Коста Рика");
            country.Add("38-30", "Каймановы острова");
            country.Add("4A-40", "США");
            country.Add("5A-50", "США");

            country.Add("6A-6W", "Австралия");
            country.Add("6X-60", "не используется");
            country.Add("7A-7E", "Новая Зеландия");
            country.Add("7F-70", "не используется");

            country.Add("8A-8E", "Аргентина");
            country.Add("8F-8K", "Чили");
            country.Add("8L-8R", "Эквадор");
            country.Add("8S-8W", "Перу");
            country.Add("8X-82", "Венесуэла");
            country.Add("83-80", "не используется");
            country.Add("9A-9E", "Бразилия");
            country.Add("9F-9K", "Колумбия");
            country.Add("9L-9R", "Парагвай");
            country.Add("9S-9W", "Уругвай");
            country.Add("9X-92", "Тринидад и Тобаго ");
            country.Add("93-99", "Бразилия");
            country.Add("90", "не используется");
            return "";
        }

        public int GetTransportYear(string vin)
        {
            return 0;
        }
    }
}
