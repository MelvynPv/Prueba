using System;

namespace Strateggy
{
    public class GuardarImagen
    {
        public IFormatImage FormatImage { get; set; }

        public void SaveImage(string imageName)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.{1}", imageName, FormatImage.ObtenerFormatoImg()));
        }
    }
}
