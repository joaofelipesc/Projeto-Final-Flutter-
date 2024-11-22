using System.Text;

public class Monitor
{
    int proximoId = 1000;

    public int Id { get; set; }
    public string Nome { get; set; }

    public string UrlFoto { get; set; }
    public List<Tuple<Dia,Horario>> Horarios { get; set; }

    public Monitor(string nome, string urlFoto)
    {
        this.Id = proximoId++;
        Nome = nome;
        UrlFoto = urlFoto;
        Horarios = new List<Tuple<Dia,Horario>>();
    }


    
    public void AdicionarHorario(Tuple<Dia,Horario> horario)
    {
        Horarios.Add(horario);
    }


    public override string ToString()
    {   
        StringBuilder sb = new StringBuilder();
        sb.Append("Monitor: " + Nome + "\n");
        for(int i = 0; i < Horarios.Count; i++)
        {
            Console.WriteLine(Horarios[i].Item1.Nome + " " + Horarios[i].Item2 + " - " + Horarios[i].Item2.inicio + " - " + Horarios[i].Item2.fim);
        }
        return sb.ToString();
    }
}