using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_PROJ_2257.Models
{
    public class Log
    {
        private string ID { get; }
        public string nome { get; }
        public bool logged { get; }

        public Log(string nome, string pass)
        {
            Connection conn = new Connection();
            if (logged = conn.checkLogin(nome, pass))
            {
                this.nome = nome;
                this.ID = conn.id;
            }
        }
    }
}