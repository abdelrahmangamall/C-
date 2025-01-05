using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static d25.Program;

namespace exceptions_25
{
    internal class deliveryService
    {
        public void start(delivery delivery)
        {
            fail(delivery);
            unknown(delivery);
            pending(delivery);
            delivered(delivery);


        }
        private void delivered(delivery delivery)
        {
            fakeIt("Delivering");
            delivery.Status = DeliveryStatus.Delivered;
        }
        private void fail(delivery delivery)
        {
            fakeIt("Failed");
            delivery.Status = DeliveryStatus.Failed;
        }
        private void pending(delivery delivery)
        {
            fakeIt("Pending");
            delivery.Status = DeliveryStatus.Pending;
        }
        private void unknown(delivery delivery)
        {
            fakeIt("Unknown");
            delivery.Status = DeliveryStatus.unknown;
        }
        private void fakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");

        }
    }
}
