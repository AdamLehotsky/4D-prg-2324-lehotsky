using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp;

namespace LibraryApp.models
{
    internal class DVD : LibraryItem<DVD>
    {
        public string Name { get; }
    }
}
