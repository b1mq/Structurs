namespace Structurs.Domain.Entities
{
    public  struct HSL
    {
        public string HSLCode { get; set; }
        public HSL(string hslCode)
        {
            HSLCode = hslCode;
        }
    }
}
