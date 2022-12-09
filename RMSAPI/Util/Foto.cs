namespace RMSAPI.Util
{
    public class Foto
    {
        public string getFoto(string foto)
        {
            var diretorio = System.IO.Directory.GetCurrentDirectory() + "/Fotos/";
            byte[] imageArray = System.IO.File.ReadAllBytes(diretorio + foto);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            return "data:image/jpeg;base64," + base64ImageRepresentation;
        }
    }
}
