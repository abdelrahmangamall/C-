namespace streamand_IO_35.Models
{
    public class DecimalSystem: Base
    { 
    
        public DecimalSystem(string val) 
        {
            val.Guard("0123456789", NumberBase.Decimal);
            this.Value = val;
        }
    } 
}
