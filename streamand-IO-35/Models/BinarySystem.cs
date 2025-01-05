namespace streamand_IO_35.Models
{
    public class BinarySystem: Base
    { 
    
        public BinarySystem(string val) 
        {
            val.Guard("01", NumberBase.Binary);
            this.Value = val;
        }
    } 

}
