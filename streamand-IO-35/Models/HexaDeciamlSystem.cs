namespace streamand_IO_35.Models
{
    public class HexaDeciamlSystem : Base
    { 
    
        public HexaDeciamlSystem(string val) 
        {
            val.Guard("0123456789ABDCEFabdcef", NumberBase.HexaDecimal);
            this.Value = val;
        }
    }

}
