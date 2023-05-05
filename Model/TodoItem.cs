using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpxAppEdu.Model
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Feito { get; set; }
    }
}
