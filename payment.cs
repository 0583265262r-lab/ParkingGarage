using System;
using System.Collections.Generic;
using System.Text;

namespace ManagePayment
{
    class Demo
    {
        static void Main()
        {
            string tt = DateTime.Now.ToString().Split()[1];
            bool result = int.TryParse(tt, out int i);

            Console.WriteLine(i - i);

        }
    }
}
