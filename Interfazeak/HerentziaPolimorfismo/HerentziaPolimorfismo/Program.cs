using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerentziaPolimorfismo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    internal class A {
        public string prop1 { get; set; }
        public virtual string prop2 { get; set; }

        public virtual void Erakutsi()
        {
            Console.WriteLine("A klasea");
            Console.WriteLine("{0}, {1}", prop1, prop2);
        }
    }

    internal class B : A
    {
        public string prop3 { get; set; }
        public override string prop2
        {
            get => base.prop2;
            set
            {
                if (value.Length < 8)
                {
                    Exception ex = new Exception("Ez da zuzena 8 karakter gutxienez");
                }
            }
        }

}
}
