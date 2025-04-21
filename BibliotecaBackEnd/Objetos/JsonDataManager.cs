using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace BibliotecaBackEnd.Objetos
{
    public static class JsonDataManager
    {
        private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
        };

        public static void GuardarDatos(string archivo, object datos)
        {
            try
            {
                string json = JsonConvert.SerializeObject(datos, settings);
                File.WriteAllText(archivo, json);
            }
            catch (Exception ex)
            {
                throw new EntradaNoValidaException($"Error al guardar datos: {ex.Message}");
            }
        }

        public static T CargarDatos<T>(string archivo)
        {
            try
            {
                if (!File.Exists(archivo))
                    return default;

                string json = File.ReadAllText(archivo);
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch (Exception ex)
            {
                throw new EntradaNoValidaException($"Error al cargar datos: {ex.Message}");
            }
        }
    }
}
