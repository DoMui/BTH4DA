using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
     public class DBCConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=LAPTOP-3JSDS55G\SQLEXPRESS01;Initial Catalog=FormDA;Integrated Security=True");

    }
}
