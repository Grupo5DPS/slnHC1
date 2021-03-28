using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IHistoria
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string idH, string detalle, string nroExpediente,
                      string Antecedente, string peso, string talla, string motivoConsulta,
                      string sintomas, string adicciones, string procedimiento, string idP,
                      string idD, string idU, string idHo, string fechaRegistro);
        //string[] Eliminar(HistoriaE historia);
        //string[] Actualizar(HistoriaE historia);
        //DataSet buscar(string texto, string criterio);
    }
}
