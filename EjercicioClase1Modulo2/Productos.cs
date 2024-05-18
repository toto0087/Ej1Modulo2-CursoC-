using System;

public class Productos
{
    [JsonPropertyName("nombre")]
    string nombre { get; set; }

    [JsonPropertyName("precio")]
    float precio { get; set; }

    [JsonPropertyName("existencias")]
    int existencias { get; set; }

    [JsonPropertyName("descuento_disponible")]
    bool descuento { get; set; }

    [JsonPropertyName("etiquetas")]
    List<string> etiquetas { get; set; }

    [JsonPropertyName("detalles")]
    List<Detalle> detalles { get; set; }

    public class Detalle
        {
            [JsonPropertyName("peso")]
            float peso { get; set; }

            [JsonPropertyName("dimensiones")]
            public List<Dimension> dimensiones { get; set; }

            public class Dimensiones
            {
                    [JsonPropertyName("alto")]
                    int alto { get; set; }

                    [JsonPropertyName("ancho")]
                    int ancho { get; set; }

                    [JsonPropertyName("profundidad")]
                    int profundidad { get; set; }
                }
            }
}
