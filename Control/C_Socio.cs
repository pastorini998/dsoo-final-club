using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Datos;


namespace ClubDeportivo.Control
{
    public class C_Socio
    {
        // Instancia de la capa de datos
        D_Socio Datos = new D_Socio();

        // El método de negocio acepta TODOS los parámetros del formulario
        public string Inscribir(string nombre, string apellido, string tdoc, string doc, string estado, DateTime fechaNacimiento, DateTime fechaInscripcion, bool aptoFisico)
        {
            // Aquí puedes agregar validaciones complejas de negocio (ej. verificar la edad)

            // Llama al método de la capa de datos, pasándole solo los 4 parámetros que el SP usa
            string respuesta = Datos.InscribirSocioConSP(nombre, apellido, tdoc, doc);

            // Nota: Los datos de fechas, estado y apto físico recogidos en el formulario
            // serán ignorados por el SP, ya que el SP los establece por defecto.
            // Si quieres guardar estos datos, el SP debe ser modificado.

            return respuesta;
        }
    }
}