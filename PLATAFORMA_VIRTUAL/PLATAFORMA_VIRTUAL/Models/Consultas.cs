using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PLATAFORMA_VIRTUAL.Models;

namespace PLATAFORMA_VIRTUAL.Models
{
    public class Consultas
    {
        private AULA_VIRTUALEntities db = new AULA_VIRTUALEntities();

        public Boolean Validar(String nick,String pass)
        {
            
            int v = db.USUARIO.Where(a=>a.Nick == nick && a.Pass == pass).Count();
            if (v == 1)
            {
                return true;
            }
            return false;
        }
        public String rol(String nick)
        {
            int id = db.USUARIO.Where(a => a.Nick == nick).First().Id;
            String rol=db.ROL.Where(a =>a.Id_Usuario == id).First().Nombre_rol;
            return rol;
        }
       
        
    }
}