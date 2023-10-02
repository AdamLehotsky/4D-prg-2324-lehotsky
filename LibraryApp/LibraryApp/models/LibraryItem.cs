using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp;

namespace LibraryApp.models
{
    internal abstract class LibraryItem<t>
    {
        private int id { get; }
        private string Title { get; }
        public bool IsAvailable { get; set; }
        public LibraryItem(int id, string Title)
        {
            this.id = id;
            this.Title = Title;
            this.IsAvailable = true;

            
        }
        public abstract void DisplayInfo();

    }
}
