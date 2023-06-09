using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class NonFiction:Book
    {
        // constructor of my Non fiction class
        public NonFiction(string title) : base(title)
        {
            this.title = title;
        }
        // giving the price that I am taking from the setPrice that is coming from the books class
        public override void SetPrice()
        {
            price = 230;
        }
    }
}
