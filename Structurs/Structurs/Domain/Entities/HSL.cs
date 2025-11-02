namespace Structurs.Domain.Entities
{
    struct HSL
    {
        public string HSLCode { get; set; }
        public HSL(string hslCode)
        {
            HSLCode = hslCode;
        }
    }
}
