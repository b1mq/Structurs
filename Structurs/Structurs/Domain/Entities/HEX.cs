using System.Xml.Linq;

namespace Structurs.Domain.Entities
{
    public  struct HEX
    {
        public string HexCode { get; set; }

        public HEX()
        {
            HexCode = String.Empty;
        }
        public HEX(string hexCode)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(hexCode);
            HexCode = hexCode;
        }
        public static string HEXtoRGBCode(string hexCode) // тут уже не я делал просто что бы все было дополнено
        {
            string hex = hexCode.StartsWith("#") ? hexCode.Substring(1) : hexCode;
            int red = Convert.ToInt32(hex.Substring(0, 2), 16);
            int green = Convert.ToInt32(hex.Substring(2, 2), 16);
            int blue = Convert.ToInt32(hex.Substring(4, 2), 16);
            return $"RGB({red}, {green}, {blue})";
        }
        public static RGB HEXtoRGB(string hexCode)
        {
            string hex = hexCode.StartsWith("#") ? hexCode.Substring(1) : hexCode;
            int red = Convert.ToInt32(hex.Substring(0, 2), 16);
            int green = Convert.ToInt32(hex.Substring(2, 2), 16);
            int blue = Convert.ToInt32(hex.Substring(4, 2), 16);
            return new RGB(red, green, blue);
        }
        public string HEXtoRGBCode() // тут уже не я делал просто что бы все было дополнено
        {
            string hex = HexCode.StartsWith("#") ? HexCode.Substring(1) : HexCode;
            int red = Convert.ToInt32(hex.Substring(0, 2), 16);
            int green = Convert.ToInt32(hex.Substring(2, 2), 16);
            int blue = Convert.ToInt32(hex.Substring(4, 2), 16);
            return $"RGB({red}, {green}, {blue})";
        }

        public RGB HEXtoRGB()
        {
            string hex = HexCode.StartsWith("#") ? HexCode.Substring(1) : HexCode;
            int red = Convert.ToInt32(hex.Substring(0, 2), 16);
            int green = Convert.ToInt32(hex.Substring(2, 2), 16);
            int blue = Convert.ToInt32(hex.Substring(4, 2), 16);
            return new RGB(red, green, blue);
        }
    }
}
