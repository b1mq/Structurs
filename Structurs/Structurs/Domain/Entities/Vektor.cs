namespace Structurs.Domain.Entities
{
    struct Vektor3
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vektor3(double x,double y,double z) 
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void ShowVektorInfo()
        {
            Console.WriteLine($"X {X}\nY {Y}\nZ {Z}");
        }
        public static Vektor3 operator *(Vektor3 vektor, double q)
        {
            return new Vektor3(vektor.X*q, vektor.Y*q, vektor.Z*q);
        }
        public static Vektor3 operator +(Vektor3 v1, Vektor3 v2)
        {
            return new Vektor3 (v1.X + v2.X,v1.Y + v2.Y,v1.Z + v2.Z);
        }
        public static Vektor3 operator -(Vektor3 v1, Vektor3 v2)
        {
            return new Vektor3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    }
}
