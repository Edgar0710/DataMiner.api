using Dapper;
using dataMiner.Data.helpers;
using dataMiner.Data.IRepository;
using DataMiner.Model;
using DataMiner.Model.Models;
using DataMinerBussiness.IBussiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataMinerBussiness.Bussiness
{
    public class UssuarioBusiness : IUsuarioBussines
    {
        IGeneralRepository<UsuarioModel> repository;
        Encriptacion util = new Encriptacion(); 
        public UssuarioBusiness(IGeneralRepository<UsuarioModel> _repository)
        {
            repository = _repository;
        }
        public Response<int> InsertarUsuario(string nombre, string appellidos, string email, string pwd)
        {
            Response<int> response = new Response<int>(); 
            try
            {
                DynamicParameters parameters = new DynamicParameters();
               
            }
            catch (Exception e)
            {

            }
            return response;

        }

        public Response<UsuarioModel> Login(string email, string password)
        {
            Response<UsuarioModel> response = new Response<UsuarioModel>();
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@email", email, DbType.String);
                parameters.Add("@pasword", util.Base64_Decode(password), DbType.String);
                response.Result = repository.GetSingle("sps_usuario", parameters);
                if (response.Result != null)
                {
                    response.Code = ResponseEnum.Ok;
                }
                else
                {
                    response.Code = ResponseEnum.No_Found;
                    response.Menssage = "El usuario o la contraseña son incorrectos";
                }
            }
            catch (Exception e)
            {
                response.Code = ResponseEnum.Fail;
                response.Menssage = "Error en el login";

            }
            return response;

        }
    }
}
