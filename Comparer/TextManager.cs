namespace Comparer
{
    public class TextManager
    {
        private string Standartise(string text)
        {
            return text.ToLower();
        }

        private string DetectShopName(string text)
        {
            if (text.Contains("maxima"))
            {
                return "maxima";
            }
            else if (text.Contains("rimi"))
            {
                return "rimi";
            }
            else
            {
                return "unrecognized";
            }
        }

        private string ExtractProducts(string text, string shopName)
        {
            if (shopName == "maxima")
            {
                text = text.Substring(text.IndexOf("kvitas"));
                text = text.Substring(text.IndexOf('\n') + 1);
                text = text.Remove(text.IndexOf("a=2") - 3);
            }

            return text;
        }

        public string PrepareText(string text)
        {
            text = Standartise(text);
            text = ExtractProducts(text, DetectShopName(text));
            return text;
        }
    }
}
