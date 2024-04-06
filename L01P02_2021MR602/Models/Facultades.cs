using System.ComponentModel.DataAnnotations;

namespace L01P02_2021MR602.Models
{
    public class Facultades
    {
        [Key]
        public int id { get; set; }

        public string facultad { get; set; }

    }

}
