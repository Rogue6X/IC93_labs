using System;


namespace oop5sh
{
    class Program
    {
        class Lines
        {
            static protected float[] coord = new float[4];

            public Lines(float[] c)
            {
                for (int i = 0; i < 4; i++)
                {
                    coord[i] = c[i];
                }
            }

            public float this[int index]
            {
                get
                {
                    return coord[index];
                }
                set
                {
                    coord[index] = value;
                }
            }

            public void Length(string name)
            {
                string res = "Length of " + name + " is " + Convert.ToString(Math.Sqrt(Math.Pow(coord[2] - coord[0], 2) + Math.Pow(coord[3] - coord[1], 2)));
                string sub = res.Substring(0, 26);
                Console.WriteLine(sub);
            }
        }
         class otrezok : Lines
        {
            public otrezok(float[] c) :base(c)
            {
                
            }
            
             public void TwoTimes()
            {
                Console.WriteLine("We double the line:");
                Console.WriteLine("Given: [" + coord[0] + "," + coord[1] + "], [" + coord[2] + "," + coord[3] + "]");
                for (int i = 0; i < 4; i++)
                {
                    coord[i] *= 2;
                }
                Console.WriteLine("Now: [" + coord[0] + "," + coord[1] + "], [" + coord[2] + "," + coord[3] + "]");
            }

            public void Show()
            {
                Console.WriteLine("Coordinates: [" + coord[0] + "," + coord[1] + "], [" + coord[2] + "," + coord[3] + "]");
            }
        }

        static void Main(string[] args)
        {
            float[] arr = new float[] { 5, 2, 4, 3 };
            otrezok Line1 = new otrezok(arr);
            Line1.TwoTimes();
            Line1.Show();
            Line1.Length("Line1");
        }
    }
}
