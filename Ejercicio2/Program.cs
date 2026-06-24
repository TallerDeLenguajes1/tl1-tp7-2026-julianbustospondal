using Personal;

SisPersonal[] empleados = new SisPersonal[3];

empleados[0] = new SisPersonal("Juan", "Perez", new DateTime(1990, 5, 15), 'S', new DateTime(2015, 3, 1), 50000, Cargos.Ingeniero);
empleados[1] = new SisPersonal("Maria", "Gomez", new DateTime(1985, 8, 20), 'C', new DateTime(2010, 6, 15), 60000, Cargos.Especialista);
empleados[2] = new SisPersonal("Carlos", "Lopez", new DateTime(1975, 12, 10), 'C', new DateTime(2000, 1, 20), 70000, Cargos.Administrativo);

double MontoTotal = 0;
for (int i = 0; i < empleados.Length; i++)
{
    MontoTotal += empleados[i].CalcularSalario();
}
Console.WriteLine($"El monto total a pagar por los tres empleados es: {MontoTotal}");
int MasProximoAJubilarse = empleados[0].AñosRestantesParaJubilarse();
int j = 0;
for (int i = 1; i < empleados.Length; i++)
{
    int añosRestantes = empleados[i].AñosRestantesParaJubilarse();
    if (añosRestantes < MasProximoAJubilarse)
    {
        MasProximoAJubilarse = añosRestantes;
        j = i;
    }
}
Console.WriteLine($"El empleado más próximo a jubilarse es {empleados[j].Nombre} {empleados[j].Apellido} con {MasProximoAJubilarse} años restantes y un salario de {empleados[j].CalcularSalario()}.");
