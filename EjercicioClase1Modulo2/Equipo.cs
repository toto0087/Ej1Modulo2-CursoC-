using System;

public class Equipo
{
    [JsonPropertyName("equipo")]
    public string? equipo { get; set; }

    [JsonPropertyName("jugadores")]
    public List<Jugador>? jugadores { get; set; }

    [JsonPropertyName("campeon")]
    public bool campeon { get; set; }

    public class Jugador
    {
        [JsonPropertyName("nombre")]
        public string? nombre { get; set; }

        [JsonPropertyName("posicion")]
        public int? kills { get; set; }

        [JsonPropertyName("numero")]
        public int death { get; set; }
    }
}
