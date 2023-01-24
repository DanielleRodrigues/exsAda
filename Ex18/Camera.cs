/*Crie uma classe Camera que deve ter como propriedades resolucaoMaxima e fotosTiradas e um método tiraFoto que apenas aumenta o número de fotos tiradas. Crie uma classe Celular que tenha como propriedades espacoDisponivel (em número de fotos), cameraFrontal e cameraTraseira. Tanto a cameraFrontal como a cameraTraseira devem ser classes que herdam de Camera e tem como propriedades adicionais a resolucaoAtual (não pode ser superior à resolucaoMaxima). Ambas apenas podem tirar fotos se houver espaço disponível no celular e a cameraFrontal deve ter resolucaoMaxima menor que a cameraTraseira*/

using System;

class Camera
{
    public int resolucaoMaxima { get; set; }
    public int fotosTiradas { get; set; }
    public void tiraFoto()
    {
        fotosTiradas++;
    }


    
}