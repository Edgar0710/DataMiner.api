using DataMiner.Model;
using DataMiner.Model.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DataMinerBussiness.IBussiness
{
    public interface IUsuarioBussines
    {
       Response<int> InsertarUsuario(string nombre,string appellidos,string email,string pwd);

       Response<UsuarioModel> Login(string email, string password);
    }

}
