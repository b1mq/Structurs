

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

        public  string RGBtoHEX()
        {
            return "#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2");
        }
    }
}
