using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public abstract class Book
    {
        // Declaring variables of title and price that I will have in the book
        protected string title;
        protected double price;

        // constructor of my class that instantiate my title
        public Book(string title)
        {
            this.title = title;
        }
        // getting the title 
        public string Title
        {
            get { return title; }
        }
        //getting the price 
        public double Price
        {
            get { return price; }
        }
        // the function that will set a price in the fiction and non fiction book 
        public abstract void SetPrice();
    }
}
