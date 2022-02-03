using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace SerializacionDeObjetos
{
    public class Auxiliar
    {
        public void Guardar(Alumno alumno, string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                bf.Serialize(fs, alumno);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            catch
            {
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public Alumno Cargar(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                Alumno a = (Alumno)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
                return a;
            }
            catch
            {
                throw;
            }
            finally
            {
                fs.Close();
            }
           
        }
    }
}
