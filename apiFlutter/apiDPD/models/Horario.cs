public class Horario
{   
    private static int proximoId = 100;
    public int Id { get; set; }
    public string inicio { get; set; } // Ex: "8:00 - 9:00"
    public string fim { get; set; } // Ex: "8:00 - 9:00"

    public Horario(string horarioinicio, string horariofim)
    {
        this. Id = proximoId++;
        inicio = horarioinicio;
        fim = horariofim;
    }


}