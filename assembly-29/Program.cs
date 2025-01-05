using System.Reflection;

namespace d29
{
    class program
    {
        public static void Main(string[] args)
        {

            //    assembly = Assembly.GetExecutingAssembly(); //another way 
            //Console.WriteLine(assembly.FullName);
            //var assemblyName = assembly.GetName();
            //Console.WriteLine($"Name: {assemblyName.Name}");
            //Console.WriteLine($"Version:{assemblyName.Version}");
            //Console.WriteLine($"total key token length:{assemblyName.GetPublicKeyToken}");
            //Console.WriteLine($"Code:{assemblyName.CodeBase}");
            //Console.WriteLine($"DateTime Assembly Name:{typeof(DateTime).Assembly.GetName().Name}");

            var type = typeof(program);
            var assembly = type.Assembly;
            Console.WriteLine(assembly);
            //display Json Data
            var stream = assembly.GetManifestResourceStream(type,"data.countries.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine((char)data[i]);
                System.Threading.Thread.Sleep(300);
            }
            stream.Close();
        }

    }
}