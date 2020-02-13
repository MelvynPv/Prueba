using System;

namespace Strateggy
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatImage formatImage;

            Console.WriteLine("Escribe el nombre de la imagen...");
            string nameImage = Console.ReadLine();
            Console.WriteLine("**********\n" +
                              "* 1. BMP *\n" +
                              "* 2. PNG *\n" +
                              "* 3. JPGE*\n" +
                              "**********");
            Console.WriteLine("Selecciona el formato para guardar...");

            string formatImg = Console.ReadLine();

            switch (formatImg)
            {
                case "1":
                    formatImage = new ImageBMP();
                    break;
                case "2":
                    formatImage = new ImagePNG();
                    break;
                case "3":
                    formatImage = new ImageJPGE();
                    break;
                default:
                    formatImage = new ImageJPGE();
                    break;
            }

            GuardarImagen guardarImagen = new GuardarImagen();
            guardarImagen.FormatImage = formatImage;
            guardarImagen.SaveImage(nameImage);
        }
    }
}
 