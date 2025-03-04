using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danexml
{
    public class Pracownik
    {
        public int Id { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public int Zarobki { get; set; }

        public DateTime Data_zatrudnienia { get; set; }

        public DateTime Data_zwolnienia { get; set; }
    }
}
