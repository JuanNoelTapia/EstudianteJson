using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using EstudianteJson;
using Newtonsoft.Json;

namespace EstudianteJson
{
    public class Json
    {
        public static void GuardarEnJson(List<Estudiante> estudiantes, string archivoJson)
        {
            var json = JsonConvert.SerializeObject(estudiantes, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }



        public static List<Estudiante> LeerDesdeJson(string archivoJson)
        {
            if (File.Exists(archivoJson))
            {
                var json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<Estudiante>>(json);
            }
            return new List<Estudiante>();
        }


    }

}
