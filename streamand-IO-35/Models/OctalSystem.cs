namespace streamand_IO_35.Models
{
    public class OctalSystem: Base
    { 
    
        public OctalSystem(string val) 
        {
            val.Guard("01234567", NumberBase.Octal);
            this.Value = val;
        }
    } 
}
