using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;

namespace d31
{
     class program
     {
        public static void Main(string[] args)
        {
            #region Attributes
            //Update[] updates = new Update[]
            //{
            //   new Update(1,"security update"),
            //   new Update(2,"ui design"),
            //   new Update(3,"bug fix"),
            //   new Update(4,"security update"),
            //};

            //UpdateProcessor.install(updates);
            //UpdateProcessor.download(updates); 
            #endregion


            #region Custom Attributes
            List<player> players = new List<player>()
            {
                 new player
                 {
                   Name="Messi",
                   BallControl = 8,
                   Dribbling = 8,
                   Power = 500,
                   Speed = 80,
                   Passing = 8
                 },
                 new player
                 {
                   Name="Rolando",
                   BallControl = 11,
                   Dribbling = 8,
                   Power = 500,
                   Speed = 80,
                   Passing = 3
                 }
            };


            var errors = new List<Error>();
            foreach (var player in players)
            {
                var properties = player.GetType().GetProperties();
                foreach(var prop in properties)
                {
                    var skillAtt = prop.GetCustomAttribute<SkillAttribute>();
                    if (skillAtt is not null)
                    {
                        var value = prop.GetValue(player);
                        if (!skillAtt.IsValid(value))
                        {
                            errors.Add(
                                new Error(prop.Name,
                                $"Invalid value, value must be between{skillAtt.Minimum}-{skillAtt.Maximum}"));
                        }
                    }
                }
            }
            #endregion
            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
                Console.WriteLine("players info are valid");
        }
     } 


     class UpdateProcessor
    {
        [Obsolete("this methode not supported for next release",false )]
        public static void download(Update[] update)
        {
            for (int i = 0; i < update.Length; i++)
            {
                Console.WriteLine($"Downloading... {update[i]}");
                System.Threading.Thread.Sleep(500);
            }
        }
        public static void install(Update[] update)
        {
            for (int i = 0; i < update.Length; i++)
            {
                Console.WriteLine($"installing... {update[i]}");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
    [DebuggerDisplay("No:{number},title:{title}")]
    class Update
    {

        private int number;
        private string title;

        public Update(int number, string title)
        {
            this.number = number;
            this.title = title;
        }


       
    }

     
    class player
    {
        public string Name { get; set; }
       
        
        [Skill(nameof(BallControl),1,10)]
        public int BallControl { get; set; }
        
        [Skill(nameof(Dribbling), 1, 20)]
        public int Dribbling { get; set; }
        
        [Skill(nameof(Power), 1, 1000)]
        public int Power { get; set; }
       
        [Skill(nameof(Speed), 1, 100)]
        public int Speed { get; set; }

        [Skill(nameof(Passing), 1, 4)]
        public int Passing { get; set; }
    }

   public class SkillAttribute : Attribute
    {
       
        public string Name { get;private set; }
        public int Minimum { get;private set; }
        public int Maximum { get;private set; }

        public SkillAttribute(string name, int minimum, int maximum)
        {
            Name = name;
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsValid(Object obj) 
        {
            var val = (int)obj;
            return val >= Minimum && val <= Maximum;
        }
    }
 
    class Error
    {
        private string field;
        private string details;

        public Error(string field, string details)
        {
            this.field = field;
            this.details = details;
        }
        public override string ToString()
        {
            return $"{{\"{field}{details}\"}}";
        }
    }


}

