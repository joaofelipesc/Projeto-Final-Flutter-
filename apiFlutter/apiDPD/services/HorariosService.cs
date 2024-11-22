using System;
using System.Collections.Generic;
using System.Linq;

public class HorariosService
{   
    
    public static Dictionary<string, List<string>> PreencherTabelaHorarios(List<Monitor> monitores)
    {
        var tabelaHorarios = new Dictionary<string, List<string>>();

        // Inicializando a tabela de horários
        tabelaHorarios["Segunda"] = new List<string>();
        tabelaHorarios["Terça"] = new List<string>();
        tabelaHorarios["Quarta"] = new List<string>();
        tabelaHorarios["Quinta"] = new List<string>();
        tabelaHorarios["Sexta"] = new List<string>();

        // Preenchendo a tabela de horários
        foreach (var monitor in monitores)
        {
            foreach (var horario in monitor.horariosMonitoria)
            {
                if (!tabelaHorarios[horario].Contains(monitor.nome))
                {
                    tabelaHorarios[horario].Add(monitor.nome);
                }
            }
        }

        return tabelaHorarios;
    }

    // Método para exibir a tabela de horários (exemplo)
    public static void ExibirTabelaHorarios(Dictionary<string, List<string>> tabelaHorarios)
    {
        foreach (var horario in tabelaHorarios)
        {
            Console.WriteLine($"{horario.Key}: {(horario.Value.Count == 0 ? "Disponível" : string.Join(", ", horario.Value))}");
        }
    }


    public static List<Tuple<string, string>> GeraHorariosDia()
    {
        return new List<Tuple<string, string>>
        {
            new Tuple<string, string>("07:30", "08:15"),
            new Tuple<string, string>("08:15", "09:00"),
            new Tuple<string, string>("09:00", "10:00"),
            new Tuple<string, string>("10:00", "10:45"),
            new Tuple<string, string>("10:45", "11:30"),
            new Tuple<string, string>("11:30", "12:15"),
            new Tuple<string, string>("12:15", "13:00"),
            new Tuple<string, string>("13:00", "13:30"),
            new Tuple<string, string>("13:30", "14:15"),
            new Tuple<string, string>("14:15", "15:00"),
            new Tuple<string, string>("15:00", "16:00"),
            new Tuple<string, string>("16:00", "16:45"),
            new Tuple<string, string>("16:45", "17:30"),
            new Tuple<string, string>("17:30", "18:15"),
            new Tuple<string, string>("18:15", "19:00"),
            new Tuple<string, string>("19:00", "19:30"),
            new Tuple<string, string>("19:45", "20:30"),
            new Tuple<string, string>("20:30", "21:30"),    
            new Tuple<string, string>("21:30", "22:15")
        };
    }

}
