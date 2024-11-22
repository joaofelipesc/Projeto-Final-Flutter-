using System;
using System.Collections.Generic;

public static class DadosMockados
{
    // Dados dos Horarios.
    public static Horario horario1 = new Horario("07:30", "08:15");
    public static Horario horario2 = new Horario("08:15", "09:00");
    public static Horario horario3 = new Horario("09:00", "10:00");
    public static Horario horario4 = new Horario("10:00", "10:45");
    public static Horario horario5 = new Horario("10:45", "11:30");
    public static Horario horario6 = new Horario("11:30", "12:15");
    public static Horario horario7 = new Horario("12:15", "13:00");
    public static Horario horario8 = new Horario("13:00", "13:30");
    public static Horario horario9 = new Horario("13:30", "14:15");
    public static Horario horario10 = new Horario("14:15", "15:00");
    public static Horario horario11 = new Horario("15:00", "16:00");
    public static Horario horario12 = new Horario("16:00", "16:45");
    public static Horario horario13 = new Horario("16:45", "17:30");
    public static Horario horario14 = new Horario("17:30", "18:15");
    public static Horario horario15 = new Horario("18:15", "19:00");
    public static Horario horario16 = new Horario("19:00", "19:30");
    public static Horario horario17 = new Horario("19:45", "20:30");
    public static Horario horario18 = new Horario("20:30", "21:30");
    public static Horario horario19 = new Horario("21:30", "22:15");

    // Dados dos Dias.
    public static Dia dia1 = new Dia("Segunda", new List<Horario> { horario1, horario2, horario3, horario4, horario5, horario6, horario7, horario8, horario9, horario10, horario11, horario12, horario13, horario14, horario15, horario16, horario17, horario18, horario19 });
    public static Dia dia2 = new Dia("Terça", new List<Horario> { horario1, horario2, horario3, horario4, horario5, horario6, horario7, horario8, horario9, horario10, horario11, horario12, horario13, horario14, horario15, horario16, horario17, horario18, horario19 });
    public static Dia dia3 = new Dia("Quarta", new List<Horario> { horario1, horario2, horario3, horario4, horario5, horario6, horario7, horario8, horario9, horario10, horario11, horario12, horario13, horario14, horario15, horario16, horario17, horario18, horario19 });
    public static Dia dia4 = new Dia("Quinta", new List<Horario> { horario1, horario2, horario3, horario4, horario5, horario6, horario7, horario8, horario9, horario10, horario11, horario12, horario13, horario14, horario15, horario16, horario17, horario18, horario19 });
    public static Dia dia5 = new Dia("Sexta", new List<Horario> { horario1, horario2, horario3, horario4, horario5, horario6, horario7, horario8, horario9, horario10, horario11, horario12, horario13, horario14, horario15, horario16, horario17, horario18, horario19 });
    public static Dia dia6 = new Dia("Sábado", new List<Horario> { horario1, horario2, horario3, horario4, horario5, horario6, horario7, horario8, horario9, horario10, horario11, horario12, horario13, horario14, horario15, horario16, horario17, horario18, horario19 });

    // Dados dos Monitores.
    public static Monitor grabalos = new Monitor("Gabriel Grabalos", "https://media.licdn.com/dms/image/v2/D5603AQGQHEyTaX5bZw/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1722463182012?e=2147483647&v=beta&t=iGR00EtaIx0XwBaHrwFjDP2jvcFh6pfjIS9m-fs61V4");
    public static Monitor beatriz = new Monitor("Beatriz", "https://images.vexels.com/media/users/3/141741/isolated/lists/c83ecdf71c3986c0e98e0e66868cf315-oculos-de-sol-cabelo-comprido-sorrindo.png");
    public static Monitor marcos = new Monitor("Marcos", "https://static.vecteezy.com/system/resources/thumbnails/009/292/244/small/default-avatar-icon-of-social-media-user-vector.jpg");
    public static Monitor anna = new Monitor("Anna", "https://media.licdn.com/dms/image/v2/D4D03AQFKuD8oLfLt_w/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1722265732157?e=2147483647&v=beta&t=4u-gMYIfnnCojjiff4v7Ot00MZc87Oe1KwrG48EQF4o");
    public static Monitor ricardo = new Monitor("Ricardo", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQk8uIBXFboZLDMtXOF-nzIksMDRi7n31jLIA&s");

    // Adicionando Horarios aos Monitores.
    static DadosMockados()
    {
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario1));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario2));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario3));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario4));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario5));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario6));

        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia2, horario1));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia2, horario2));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia2, horario3));

        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario1));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario14));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario15));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario16));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario17));

        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario1));
        grabalos.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario2));

        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario1));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario2));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario3));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario4));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario5));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario6));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario7));

        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia2, horario1));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia2, horario2));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia2, horario3));

        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario1));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario13));

        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario1));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario2));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario7));
        beatriz.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario8));

        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario2));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario3));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario4));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario5));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario6));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia1, horario7));

        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia4, horario1));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia4, horario2));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia4, horario3));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia4, horario4));

        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario1));
        marcos.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario2));

        anna.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario1));
        anna.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario14));
        anna.AdicionarHorario(new Tuple<Dia, Horario>(dia3, horario15));

        ricardo.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario9));
        ricardo.AdicionarHorario(new Tuple<Dia, Horario>(dia5, horario10));

    }
}
