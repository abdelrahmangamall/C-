namespace d30
{
    class program
    {
        public static void Main(string[] args)
        {

            Type t1 = DateTime.Now.GetType(); // at run time
                                              
            Type t2 = typeof(DateTime); // at compile time

            var t3 = typeof(program);
            Console.WriteLine(t3);
            Console.WriteLine($"T2 {t2}");
            Console.WriteLine(t2.FullName); //namespace.typeName
            Console.WriteLine(t2.Name); // namespace
            Console.WriteLine(t2.BaseType); // 
            Console.WriteLine($"Is public : {t2.IsPublic}");
            Console.WriteLine($"Is public : {t2.Assembly}");

            Type t4 = typeof(int[,]);
            Console.WriteLine(t4);


            var nestedTypes = typeof(employe).GetNestedTypes();
            for (int i = 0; i < nestedTypes.Length; i++)
            {
                Console.WriteLine(nestedTypes[i]);
            
            }

            var t5 = typeof(int);
            var interf = t5.GetInterfaces();
            for(int i = 0; i <interf.Length; i++)
            {
                Console.WriteLine(interf[i]);
            }


        }


    }
    class employe
    {

    }

}