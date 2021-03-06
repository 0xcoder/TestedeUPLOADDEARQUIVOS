using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.MVC.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string nome { get; set; }

        public virtual ICollection<FileModel> files { get; set; }

    }
}
