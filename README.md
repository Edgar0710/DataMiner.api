# DataMiner.api
Es el backend de la aplicacion DataMiner cuyo objetivo es el amejo de informacion proveniente del archivo excel que se genera en microsoft forms
## Integrantes ✒️
* Edgar Carrera Carrasco 
* Ivan Gonzalez Dominguez
## Descripcion
El proyecto es una wepapi creada con asp.net core 3.1 se enceuntra estructurado conun modelo en capas mediante el uso de interfaces.

## Congigurtación y estructura
- Proyecto principal webapi asp.net core 3.1
- Libreria de clases .net core
    - Bussines (implementacion reglas de negocio)
    - Data (conexion y manejo de datos)
    - Model (objwetps de conexión)

## Librerias necesarias
* Dapper 2.0.78
* ExcelDataReader 3.6.0
* Microsoft.AspNetCore.Mvc.Newtonsof 3.1.11
* Microsoft.IdentityModel.Logging 6.8.0
* Newtonsoft.Json 12.0.3
* Swashbuckle.AspNetCore 6..1.0
* System.Data.SqlClient 4.8.2
* TourmalineCore.AspNetCore.JwtAuthentication.Core 0.1.1
 
 ## Endpints
 para probar en tiempo rela puedes dar click [aqui](https://45.63.18.178:449/swagger/index.html)
 ![img](https://github.com/Edgar0710/Data-Miner/blob/main/documents/api.PNG)
 
 ## Objeto  de respuestas
 - Code
    -404 Not Found
    -501 internal error
    -200 Ok
    -401 unauthorize
- result (object)
- Message (cadena de texto: mensajes de error etc)

### Caracteristicas del archivo excel requerido
![img](https://github.com/Edgar0710/Data-Miner/blob/main/documents/excel.PNG)

El archivo debe contener las carectiristicas  nativas de microsoft forms  dicho excel se compone por las siguientes columnas
Nota: Esta configuracion se hizo en base a cuestionarios publicos es por ello que la columna nombre nativa no se considera y en cambio se usa 
toma como nombre el registro de la primer pregunta en caso de que se tengza una configuracion diferente asegurece de cambiar el campo que se considera en el en point alta de formulario
ID	Hora de inicio	Hora de finalización	Correo electrónico	Nombre	 Nombre Pregunta_1  pregunta_2  pregunta_n
![image](https://user-images.githubusercontent.com/60529884/111859120-06175900-8904-11eb-8d42-73abdea7130d.png)



