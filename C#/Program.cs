using System.Numerics;

namespace d12
{
    class program
    {
        public static void Main(String[] args)
        {
           // Ip ip = new Ip(125, 54, 659, 489);
            Ip ip = new Ip("123.125.122.100");
          //  Console.WriteLine(ip.address);
            ip[0] = 253;
          //  Console.WriteLine(ip[0]);
            
            // Declare and initialize a 9x9 matrix
            int[,] Matrix = new int[,]
            {
            { 5, 3, 1, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 1, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };
            var amt = Matrix[3, 3];
            //int[,] value = new int[5, 5];
            soduko sod = new soduko(Matrix);
            Console.WriteLine(sod[6,6]);
        }

    }
    class soduko // index with 2dimentional array
    {
        int[,] matrix;

        public int this[int x, int y]
        {
            get {
                if (x < 0 || x > matrix.GetLength(0) - 1)
                    return -1; 
                
                if (y < 0 || y > matrix.GetLength(1) - 1)
                    return -1;
 
                return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

            public soduko(int[,] mat)
        {
            matrix = mat;   
        }
    }

    class Ip  // index in array with 1 dimentional
    {
        int[] ipAdd = new int[4];


        public int this[int index]
        {
            get { return ipAdd[index]; }
            set { ipAdd[index] = value; }
        }

        public Ip(String IpAddress)
        {
            var ipp = IpAddress.Split(".");
            for (int i = 0; i < ipp.Length; i++)
            {
                  ipAdd[i] =int.Parse(ipp[i]);
            }
        }
        public Ip(int p1, int p2,int p3, int p4)
        {
            ipAdd[0] = p1;
            ipAdd[1] = p2;
            ipAdd[2] = p3;
            ipAdd[3] = p4;
        }

        
        // converrt to string with split
        public String address => String.Join(".", ipAdd);  
    }
}
