
using Comparer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForComparer
{
    [TestClass]
    public class UnitTestTextManagerPrepare
    {
        // Contains shop name
        [TestMethod]
        public void UnitTestTextManagerPrepareTextContainShopName()
        {
            TextManager textManager = new TextManager();
            string text = "MA" +
            "HAX IMA LT, UAB" +
            "Savanoriu pr. 247, Vilnius, Kasa Nr. 13" +
            "PUM moketojo kodas LT230335113" +
            "Kvitas 1 / 15 #00000908" +
            "Liesa Varške OPTIMA LINIJA, 0,5 % rieb. 0,45 A" +
            " Grikiu kruopos OPTIMA LINIJA(4 x 100 g) 0,79 A" +
            "Grietine FARM MILK, 30 % rieb 0,73 A" +
            " Pienas OPTIMA LINIJA, 3,5 % 0,59 A" +
            "  Saulegražu aliejus OPTIMA LINIJA 1,27 A" +
            "  Kiaušiniai OPTIMA LINIJA(MI, rudi) 0,99 A" +
            " Pirkiniu maišelis 25mk MAXIMA(30 / 7x50 cm) 0,08 A" +
            "  | A - 21,008" +
            "PUM" +
            "0,85" +
            "Be PUM" +
            "4,05" +
            "Su PUM" +
            "4,90" +
            "Moketi" +
            "Moketa(Banko kortele)" +
            "4,90" +
            "4,90" +
            "MOKEJIMAS KORTELE" +
            "PARDAVIMAS" +
            "DOKUMENTO NR 005656:170323 143457" +
            "I KVITO NR 100596" +
            "TERMINAL ID 03189910" +
            "MERCHANT ID 0032181110" +
            "LAIKAS 2017 - 03 - 23 14:34:57" +
            "Debit MasterCard ********XXXXX4376" +
            "A0000000041010 TVR : 0000008000" +
            "TSI: E800 AIP:3900 TC: 146CD888D4C6DBE5" +
            "  DEBIT MASTERCARD" +
            "  SUMA 4, 90 EUR" +
            "  Autorizacijos Nr 242896 T: 1" +
            "PIN KODAS TEISINGAS" +
            "IŠSAUGOKITE CEKIO KOPIJA SASKAITOS" +
            "IšRAŠ0 PATIKRINIMUI" +
            "RRN: 708266988518" +
            ":" +
            "InvÑr: 1300 - 0130 - 0150 - 0014" +
            "ACIU, KAD PIRKOTE!" +
            "* Daugiau informacijos sužinokite" +
            "WWW.Maxima.lt ir telefonu 8 800 20050" +
            "Kasininkas(-é) 10457 13" +
            "LF JB 0000004A91D6 2017 - 03 - 23 14:35:09";
            text = textManager.PrepareText(text);
            Assert.IsTrue(text.Contains("maxima"));
        }

        // Contains information about not found parameters
        [TestMethod]
        public void UnitTestTextManagerPrepareTextNotEmpty()
        {
            TextManager textManager = new TextManager();
            string text = "";
            text = textManager.PrepareText(text);
            Assert.IsTrue(text.Length != 0);
        }
    }
}
