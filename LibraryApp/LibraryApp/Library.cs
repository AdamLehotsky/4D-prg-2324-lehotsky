using LibraryApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp;

namespace LibraryApp
{
    internal class Library<t> where t : LibraryItem<t>
    {
        List<t> items = new List<t>();
        public void Add(t item)
        {
            items.Add(item);

        }
        public void ListItems(Book DVD)
        {
            Console.WriteLine("items");
            foreach(t item in items)
            {
                item.DisplayInfo();
            }
        }
        public void CheckoutInfo(int id){
            itemToCheckout = items.Find(item => item id == id);
            if(itemToCheckout != null)
            {
                if(itemToCheckout IsAvailable){
                    itemToCheckout IsAvailable = false;
                    Console.WriteLine($"Vypůjčil jsem si knížku: {itemToCheckout.Title}")
                    
                }
                else
                {
                    throw new NotAvailableException($"Položka s ID ${itemToCheckout.Id} nebyla nalezena")
                }
            }
        }
    }
}
