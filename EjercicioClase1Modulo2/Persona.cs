using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace EjercicioClase1Modulo2.Ejercicio1
{
    public class Persona
    {

        [JsonPropertyName("usuario")]
        public string? usuario { get; set; }

        [JsonPropertyName("amigos_usuario")]
        public List<string>? amigos { get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool notificacion { get; set; }
    }
}
