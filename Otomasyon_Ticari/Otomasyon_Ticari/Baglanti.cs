
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otomasyon_Ticari
{
    class Baglanti
    {
        public NpgsqlConnection baglanti() {
            NpgsqlConnection baglan = new NpgsqlConnection("Server=Localhost; Port=5432; Password=onur;Database=ticari_Otomasyon ;User Id=postgres");
            baglan.Open();
            return baglan;
        }
    
        

    }
}
