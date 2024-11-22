using System.Globalization;

public class MonitorService
{
    public static double CalcularHorasTrabalhadas(Monitor monitor)
    {
        double totalHoras = 0;

        foreach (var horario in monitor.horariosMonitoria)
        {
            var partesHorario = horario.Split(" - ");
            if (partesHorario.Length == 2)
            {
                var horaInicio = DateTime.ParseExact(partesHorario[0], "HH:mm", CultureInfo.InvariantCulture);
                var horaFim = DateTime.ParseExact(partesHorario[1], "HH:mm", CultureInfo.InvariantCulture);

                totalHoras += (horaFim - horaInicio).TotalHours;
            }
        }

        return totalHoras;
    }

    public static bool TrabalhaNoDia(Monitor monitor, string dia)
    {
        foreach (var horario in monitor.horariosMonitoria)
        {
            if (horario.StartsWith(dia))
            {
                return true;
            }
        }
        return false;
    }

    public static double CalcularHorasTrabalhadasPorDia(Monitor monitor, string dia)
    {
        double totalHorasDia = 0;

        foreach (var horario in monitor.horariosMonitoria)
        {
            if (horario.StartsWith(dia))
            {
                var partesHorario = horario.Split(" - ");
                if (partesHorario.Length == 2)
                {
                    var horaInicio = DateTime.ParseExact(partesHorario[0], "HH:mm", CultureInfo.InvariantCulture);
                    var horaFim = DateTime.ParseExact(partesHorario[1], "HH:mm", CultureInfo.InvariantCulture);
                    totalHorasDia += (horaFim - horaInicio).TotalHours;
                }
            }
        }

        return totalHorasDia;
    }



}