using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak Class Kalmasın...
    // Herhangi Bir classta inheritance yoksa sıkıntı yaşanabilme oranı yüksektir..
    public class Category:IEntity
    {
        public int CategoryID{ get; set; }
        public string CategoryName { get; set; }

    }
}
