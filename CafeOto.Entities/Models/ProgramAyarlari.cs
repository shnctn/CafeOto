using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOto.Entities.Interfaces;

namespace CafeOto.Entities.Models
{   [Table("ProgramAyarlari")]
     public class ProgramAyarlari:IEntity
     {
         public int Id { get; set; }
         public string AyarTanimi { get; set; }
         public string  AyarAdi { get; set; }

    }
}
