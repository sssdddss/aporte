class Program
{
    public static void Main(String[] args)
    {

        
        var smartphone = new Dispositivo1();
        Console.WriteLine(smartphone.reparar());

        var reparacion1 = new camara_rota(smartphone);
        Console.WriteLine(reparacion1.reparar());

        var reparacion2 = new Puerto_de_carga(smartphone);
        Console.WriteLine(reparacion2.reparar());

        var reparacion3 = new Malware(smartphone);
        Console.WriteLine(reparacion3.reparar());

        Console.WriteLine(smartphone.hardwareadd());

        var cargador = new Cargador(smartphone);
        Console.WriteLine(cargador.hardwareadd());


        Console.WriteLine("");
        var smartphone2 = new Dispositivo2();
        Console.WriteLine(smartphone2.reparar());

        var reparacion4 = new Puerto_de_carga(smartphone2);
        Console.WriteLine(reparacion4.reparar());

        var reparacion5 = new Malware(smartphone2);
        Console.WriteLine(reparacion5.reparar());

        var reparacion6 = new camara_rota(smartphone2);
        Console.WriteLine(reparacion6.reparar());

        Console.WriteLine(smartphone2.hardwareadd());

        var parlante2 = new USB(smartphone2);
        Console.WriteLine(parlante2.hardwareadd());
        Console.WriteLine("");
        Console.WriteLine("");


        
        var smartphone3 = new Dispositivo3();
        Console.WriteLine(smartphone3.reparar());

        var reparacion7 = new Puerto_de_carga(smartphone3);
        Console.WriteLine(reparacion7.reparar());

        var reparacion8 = new Malware(smartphone3);
        Console.WriteLine(reparacion8.reparar());

        var reparacion9 = new camara_rota(smartphone3);
        Console.WriteLine(reparacion9.reparar());

        Console.WriteLine(smartphone3.hardwareadd());

        var audifonos3 = new audifonos(smartphone3);
        Console.WriteLine(audifonos3.hardwareadd());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
    }
}