using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Pedido_Produto.Controllers
{
    public class ConectionController : Controller
    {
        SqlConnection conection = new SqlConnection();

        public ConectionController()
        {
            this.conection.ConnectionString = @"Data Source=VMI368814;Initial Catalog=PedidoProduto;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (this.conection.State == System.Data.ConnectionState.Closed)
            {
                this.conection.Open();
            }
            return this.conection;
        }

        public void desconectar()
        {
            if (this.conection.State == System.Data.ConnectionState.Open)
            {
                this.conection.Close();
            }

        }

    }
}
