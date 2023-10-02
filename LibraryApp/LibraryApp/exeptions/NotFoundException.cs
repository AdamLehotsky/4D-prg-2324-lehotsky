using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.exeptions
{
    internal class NotFoundException
    {
        public NotFoundException(string message = "Položka nebyla nalezena") : base(message) { }
    }
}
