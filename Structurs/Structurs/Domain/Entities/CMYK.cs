namespace Structurs.Domain.Entities
{
    struct CMYK
    {
        string CMYKCode { get; set; }

        public CMYK() { CMYKCode = String.Empty; }
        public CMYK(string cmykCode) {
            CMYKCode = cmykCode;
        }

    }
}
