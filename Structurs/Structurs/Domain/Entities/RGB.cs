

namespace Structurs.Domain.Entities
{
    struct RGB
    {
        public int Red {  get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public RGB(int red, int green, int blue)
        {
            if ( red >= 0 && green >= 0 && blue >= 0 && red <= 255 && green <= 255 && blue <= 255)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }else
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
    }

}
