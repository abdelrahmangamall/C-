namespace d25
{
    partial class Program
    {
        public class delivery
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string customerName { get; set; }
            public DeliveryStatus Status { get; set; }

            public delivery(string name, string address, string customerName)
            {
                Name = name;
                Address = address;
                this.customerName = customerName;
               // Status = status;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Address: {Address}, CustomerName: {customerName}, Status: {Status}";
            }
        }
    }
}