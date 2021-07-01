using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public class PdfFile : File
    {
        public PdfFile(string name, bool isEditable)
            : base(name, "pdf")
        {
            this.IsEditable = isEditable;
        }

        public bool IsEditable
        {
            get;
        }

        public void AttemptEdit()
        {
            if (this.IsEditable)
            {
                Console.WriteLine($"Editing file '{this.Name}.{this.Extension}'");
            }
            else
            {
                Console.WriteLine($"File '{this.Name}.{this.Extension}' doesn't support editing");
            }
        }
    }
}
