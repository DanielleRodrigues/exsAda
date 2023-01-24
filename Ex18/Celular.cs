class Celular
{
    public int espacoDisponivel { get; set; }
    public CameraFrontal cameraFrontal { get; set; }
    public CameraTraseira cameraTraseira { get; set; }

    public void tiraFoto(bool frontal)
    {
        if (espacoDisponivel <= 0)
        {
            Console.WriteLine("Espaço insuficiente para tirar fotos.");
            return;
        }

        if (frontal)
        {
            if (cameraFrontal.resolucaoAtual > cameraFrontal.resolucaoMaxima)
            {
                Console.WriteLine("Resolução atual da câmera frontal é superior à máxima permitida.");
                return;
            }
            cameraFrontal.tiraFoto();
        }
        else
        {
            if (cameraTraseira.resolucaoAtual > cameraTraseira.resolucaoMaxima)
            {
                Console.WriteLine("Resolução atual da câmera traseira é superior à máxima permitida.");
                return;
            }
            cameraTraseira.tiraFoto();
        }
        espacoDisponivel--;
    }
    /*Celular celular = new Celular();
    celular.espacoDisponivel = 10;

    celular.cameraFrontal = new CameraFrontal();
    celular.cameraFrontal.resolucaoMaxima = 2;
    celular.cameraFrontal.resolucaoAtual = 1;

    celular.cameraTraseira = new CameraTraseira();
    celular.cameraTraseira.resolucaoMaxima = 5;
    celular.cameraTraseira.resolucaoAtual = 3;

    celular.tiraFoto(true); 
    Console.WriteLine("Fotos tiradas com câmera frontal: " + celular.cameraFrontal.fotosTiradas);

    celular.tiraFoto(false); 
    Console.WriteLine("Fotos tiradas com câmera traseira: " + celular.cameraTraseira.fotosTiradas);

    celular.cameraTraseira.resolucaoAtual = 6;
    celular.tiraFoto(false);
    Console.WriteLine("Fotos tiradas com câmera traseira: " + celular.cameraTraseira.fotosTiradas);*/
}


