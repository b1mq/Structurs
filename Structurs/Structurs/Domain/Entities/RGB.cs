

namespace Structurs.Domain.Entities
{
    struct RGB
    {
        public int Red {  get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public RGB ()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }
        public RGB(int red, int green, int blue)
        {
            if ( red >= 0 && green >= 0 && blue >= 0 && red <= 255 && green <= 255 && blue <= 255)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
            else
            {
                throw new ArgumentException("Some of the color is negative or more than 255");
            }

        }
        public static string RGBCodeToHexCode(int red, int green, int blue)
        {
            if (red >= 0 && green >= 0 && blue >= 0 && red <= 255 && green <= 255 && blue <= 255)
            {
                return ("#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2"));
            }
            else
            {
                throw new ArgumentException("Some of the color is negative or more than 255");
            }
        }
        public static string RGBToHexCode(RGB rgb)
        {
            return ("#" + rgb.Red.ToString("X2") + rgb.Green.ToString("X2") + rgb.Blue.ToString("X2"));
        }
        public string RGBtoHEXCode()
        {
            return ("#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2"));
        }
        public  HEX RGBtoHEX()
        {
            return new HEX( "#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2")) ;
        }
        public static string RgbCodeToCMYKCode(int R,int G,int B)
        {
            double r = R / 255;
            double g = G / 255;
            double b = B / 255;
            double K = 1 - Math.Max(Math.Max(r, g), b);

            if (K == 1)
            {
                int C = 0;
                int M = 0;
                int Y = 0;
                return $"{C}%, {M}%, {Y}%, {K}%";
            }
            else
            {
                double C = (1 - r - K) / (1 - K);
                double M = (1 - g - K) / (1 - K);
                double Y = (1 - b - K) / (1 - K);
                return $"{C}%, {M}%, {Y}%, {K}%";
            }

        }
        public string RgbCodeToCMYKCode()
        {
            double r = Red / 255;
            double g = Green / 255;
            double b = Blue / 255;
            double K = 1 - Math.Max(Math.Max(r, g), b);

            if(K == 1)
            {
                int C = 0;
                int M = 0;
                int Y = 0;
                return $"{C}%, {M}%, {Y}%, {K}%";
            }
            else
            {
                double C = (1 - r - K) / (1 - K);
                double M = (1 - g - K) / (1 - K);
                double Y = (1 - b - K) / (1 - K);
                return $"{C}%, {M}%, {Y}%, {K}%";
            }

        }
        public CMYK RgbToCMYK()
        {
            double r = Red / 255;
            double g = Green / 255;
            double b = Blue / 255;
            double K = 1 - Math.Max(Math.Max(r, g), b);

            if (K == 1)
            {
                int C = 0;
                int M = 0;
                int Y = 0;
                return new CMYK($"{C}%, {M}%, {Y}%, {K}%");
            }
            else
            {
                double C = (1 - r - K) / (1 - K);
                double M = (1 - g - K) / (1 - K);
                double Y = (1 - b - K) / (1 - K);
                return new CMYK($"{C}%, {M}%, {Y}%, {K}%");
            }


        }
        public HSL  RgbCodeToHSL(int red, int green, int blue)
        {
            double r = red / 255;
            double g = green / 255;
            double b = blue / 255;
            double maxvalue = Math.Max(Math.Max(r, g), b);
            double minvalue = Math.Min(Math.Min(r, g), b);
            double delta = maxvalue - minvalue;
            double L = (maxvalue + minvalue) / 2;
            double H = 0;
            double S = 0;
            if (delta != 0)
            {
                S = delta / (1 - Math.Abs(2 * L - 1));


                if (maxvalue == r)
                    H = 60 * (((g - b) / delta) % 6);
                else if (maxvalue == g)
                    H = 60 * (((b - r) / delta) + 2);
                else
                    H = 60 * (((r - g) / delta) + 4);
            }
            if (H < 0)
            {
                H += 360;
            }

            return new HSL($"H: {H:F0}, S: {S * 100:F0}%, L: {L * 100:F0}%");
        }
        public static string RgbCodeToHSLCode(int red,int green,int blue)
        {
            double r = red / 255;
            double g = green / 255;
            double b = blue / 255;
            double maxvalue = Math.Max(Math.Max(r, g), b);
            double minvalue = Math.Min(Math.Min(r, g), b);
            double delta = maxvalue - minvalue;
            double L = (maxvalue + minvalue) / 2;
            double H = 0;
            double S = 0;
            if (delta != 0)
            {
                S = delta / (1 - Math.Abs(2 * L - 1));


                if (maxvalue == r)
                    H = 60 * (((g - b) / delta) % 6);
                else if (maxvalue == g)
                    H = 60 * (((b - r) / delta) + 2);
                else
                    H = 60 * (((r - g) / delta) + 4);
            }
            if (H < 0)
            {
                H += 360;
            }

            return $"H: {H:F0}, S: {S * 100:F0}%, L: {L * 100:F0}%";
        }
        public string RgbCodeToHSLCode()
        {
            double r = Red / 255;
            double g = Green/ 255;
            double b = Blue / 255;
            double maxvalue = Math.Max(Math.Max(r, g),b);
            double minvalue = Math.Min(Math.Min(r, g),b);
            double delta = maxvalue - minvalue;
            double L = (maxvalue + minvalue) / 2;
            double H = 0;
            double S = 0;
            if (delta != 0)
            {
                S = delta / (1 - Math.Abs(2 * L - 1));


                if (maxvalue == r)
                    H = 60 * (((g - b) / delta) % 6);
                else if (maxvalue == g)
                    H = 60 * (((b - r) / delta) + 2);
                else
                    H = 60 * (((r - g) / delta) + 4);
            }
            if (H < 0)
            {
                H += 360;
            }
             
            return $"H: {H:F0}, S: {S * 100:F0}%, L: {L * 100:F0}%";
        }
        public HSL RgbCodeToHSL()
        {
            double r = Red / 255;
            double g = Green / 255;
            double b = Blue / 255;
            double maxvalue = Math.Max(Math.Max(r, g), b);
            double minvalue = Math.Min(Math.Min(r, g), b);
            double delta = maxvalue - minvalue;
            double L = (maxvalue + minvalue) / 2;
            double H = 0;
            double S = 0;
            if (delta != 0)
            {
                S = delta / (1 - Math.Abs(2 * L - 1));


                if (maxvalue == r)
                    H = 60 * (((g - b) / delta) % 6);
                else if (maxvalue == g)
                    H = 60 * (((b - r) / delta) + 2);
                else
                    H = 60 * (((r - g) / delta) + 4);
            }
            if (H < 0)
            {
                H += 360;
            }

            return new HSL($"H: {H:F0}, S: {S * 100:F0}%, L: {L * 100:F0}%");
        }
    }
}



