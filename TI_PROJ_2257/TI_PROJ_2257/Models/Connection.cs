using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_PROJ_2257.Models
{
    public class Connection
    {
        AgendaEntities database = new AgendaEntities();
        public string id;
        private bool isLogged { get; }
        public bool checkLogin(string user, string pass)
        {
            bool isLogged = false;
            utilizador u = database.utilizadors.SingleOrDefault(x => x.username == user);
            if (u != null)
                if(u.pass == pass)
                {
                    isLogged = true;
                    this.id = u.id.ToString();
                }
            return isLogged;
        }
    }
}