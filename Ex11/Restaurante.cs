/*Crie uma classe Restaurante com as propriedades cidade, 
delivery (verdadeiro ou falso), pedidosPendentes e 
tempo de entrega estimado (calculado com base nos pedidos pendentes, sendo 10 + 2 * pedidosPendentes em minutos). 
Os restaurantes devem ser capazes de realizar entregas desde que o cliente esteja localizado na mesma cidade e, 
para isso, precisamos de um método entregaPedido que devolve como resultado se é possível realizar a entrega para um determinado cliente ou não e, 
em caso positivo, o tempo estimado de entrega.*/

class Restaurante
{
    public string cidade { get; set; }
    public bool delivery { get; set; }
    public int pedidosPendentes { get; set; }

    public int TempoEntregaEstimado
    {
        get { return 10 + 2 * pedidosPendentes; }
    }

    public bool entregaPedido(string cidadeCliente)
    {
        if (delivery && cidadeCliente == cidade)
        {
            return true;
        }
        return false;
    }

    public int tempoEntrega(string cidadeCliente)
    {
        if (entregaPedido(cidadeCliente))
        {
            return TempoEntregaEstimado;
        }
        return 0;
    }

    /*Restaurante restaurante = new Restaurante();
    restaurante.cidade = "São Paulo";
    restaurante.delivery = true;
    restaurante.pedidosPendentes = 5;
    string cidadeCliente = "São Paulo";

    if (restaurante.entregaPedido(cidadeCliente))
    {
        Console.WriteLine("Entrega possível, tempo estimado: " + restaurante.tempoEntrega(cidadeCliente) + " minutos.");
    }
    else
    {
        Console.WriteLine("Entrega não possível para essa cidade.");
    }*/
}
