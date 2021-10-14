using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Category
    {
        //erisim belirleyici türü -değisken türü -isim {get set}
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }
        //category'i aktif ya da pasife çekmek için


    }
}
