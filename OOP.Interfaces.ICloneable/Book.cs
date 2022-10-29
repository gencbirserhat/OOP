using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.ICloneables
{
    public class Book : ICloneable
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }

        
        
        public object Clone()
        {
            // a deep copy
            return new Book()
            {
                Id = this.Id,
                Title = this.Title,
                Price = this.Price
            }; 

            // shallow copy (alternative)
            //return this.MemberwiseClone(); 
        }
    }
}
