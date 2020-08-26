using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWindowForms
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.ShowDialog();
            Console.ReadKey();
        }
    }
}
