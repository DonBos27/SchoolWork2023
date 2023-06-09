using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Fiction:Book
    {
        // constructor of my fiction class
        public Fiction(string title) : base(title)
        {
            this.title = title;
        }
        // giving the price that I am taking from the setPrice that is coming from the books class
        public override void SetPrice()
        {
            price = 170;
        }
    }
}
