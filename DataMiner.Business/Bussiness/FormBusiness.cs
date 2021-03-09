using Dapper;
using dataMiner.Data.IRepository;
using DataMiner.Model;
using DataMinerBussiness.IBussiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataMinerBussiness.Bussiness
{
    public class FormBusiness : IformBusiness
    {
        IGeneralRepository<object> repository;
        public FormBusiness(IGeneralRepository<object> _repository) {
            repository = _repository;
        }

        public Response<object> GetForms(int usuario)
        {
            Response<object> response = new Response<object>();
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@us_id", usuario, DbType.Int32);
                response.Result = repository.GetList("sps_forms", parameters);
                response.Code = ResponseEnum.Ok;


            }
            catch (Exception ex)
            {
                response.Code = ResponseEnum.Fail;
                response.Menssage = "Error al procesar la solicitud";

            }
            return response;
        }

        public Response<object> GetRespuestaFormulario(int form)
        {
              Response<object> response = new Response<object>();
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@fr_id", form, DbType.Int32);
                response.Result = repository.GetList("sps_pregutasbyFormulario", parameters);
                response.Code = ResponseEnum.Ok;


            }catch(Exception ex)
            {
                response.Code = ResponseEnum.Fail;
                response.Menssage = "Error al procesar la solicitud";

            }
            return response;
        }

        public Response<int> InsertaForm(string nombre, string descripcion, int usuario)
        {
            Response<int> response = new Response<int>();
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@frm_nombre", nombre, DbType.String);
                parameters.Add("@descripcion", descripcion, DbType.String);
                parameters.Add("@us_id", usuario, DbType.Int32);
                response.Result = repository.Execute("spi_Formulario", parameters,true);
                response.Code = ResponseEnum.Ok;

            }
            catch (Exception ex)
            {
                response.Code = ResponseEnum.Fail;
                response.Menssage = "Error al procesar la solicitud";

            }
            return response;
        }

        public Response<object> InsertaRespuestas(string en_nombre, string en_email, string pregunta, string respuesta, int formulario)
        {
            Response<object> response = new Response<object>();
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@en_nombre", en_nombre, DbType.String);
                parameters.Add("@en_email", en_email, DbType.String);
                parameters.Add("@pr_pregunta", pregunta, DbType.String);
                parameters.Add("@re_valor", respuesta, DbType.String);
                parameters.Add("@fr_id", formulario, DbType.Int32);
                 repository.Execute("spI_respuestas", parameters);
                response.Result = 1;
                response.Code = ResponseEnum.Ok;

            }
            catch (Exception ex)
            {
                response.Code = ResponseEnum.Fail;
                response.Menssage = "Error al procesar la solicitud";

            }
            return response;
        }
    }
}
