using DataMiner.Model;


namespace DataMinerBussiness.IBussiness
{
    public interface IformBusiness
    {
        
        Response<object> GetForms(int usuario);
        Response<object> GetRespuestaFormulario(int usuario);
        Response<int> InsertaForm(string nombre, string descripcion, int usuario);
        Response<object> InsertaRespuestas(string en_nombre, string en_email, string pregunta, string respuesta, int formulario);
    }
}
