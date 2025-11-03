using System.Text;

namespace Structurs.Domain.Entities
{
    public struct Number
    {
        csharpusing System;
using System.Text;

namespace DecimalNumberSystem
    {
        public struct DecimalNumber
        {
            public long Value { get; set; }

            public DecimalNumber(long number)
            {
                Value = number;
            }

            public string ToBinary()
            {
                if (Value == 0) return "0";

                bool isNegative = Value < 0;
                long num = Math.Abs(Value);
                StringBuilder result = new StringBuilder();

                while (num > 0)
                {
                    result.Insert(0, num % 2);
                    num /= 2;
                }

                if (isNegative)
                    result.Insert(0, '-');

                return result.ToString();
            }

            public string ToOctal()
            {
                if (Value == 0) return "0";

                bool isNegative = Value < 0;
                long num = Math.Abs(Value);
                StringBuilder result = new StringBuilder();

                while (num > 0)
                {
                    result.Insert(0, num % 8);
                    num /= 8;
                }

                if (isNegative)
                    result.Insert(0, '-');

                return result.ToString();
            }

            public string ToHexadecimal()
            {
                if (Value == 0) return "0";

                bool isNegative = Value < 0;
                long num = Math.Abs(Value);
                StringBuilder result = new StringBuilder();
                char[] hexChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

                while (num > 0)
                {
                    result.Insert(0, hexChars[num % 16]);
                    num /= 16;
                }

                if (isNegative)
                    result.Insert(0, '-');

                return result.ToString();
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
