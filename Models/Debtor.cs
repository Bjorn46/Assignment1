using SQLite;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.DataModels
{
   
        public class Debtor
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }

            [Required]
            [StringLength(50)]
            public string Name { get; set; }

            [Range(0, double.MaxValue)]
            public double Amount { get; set; }

        }
    }

