public class Dia
{
    int proximoId = 50;
    public int Id { get; set; }

    public string Nome { get; set; }

    public Dia(string nome, List<Horario> horarios)
    {
        this.Id = 1 + proximoId++;
        Nome = nome;
    }
}

