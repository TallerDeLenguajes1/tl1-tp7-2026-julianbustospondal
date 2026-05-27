using Personal;

SisPersonal[] empleados = new SisPersonal[3];

empleados[0] = new SisPersonal("Juan", "Perez", new DateTime(1990, 5, 15), 'S', new DateTime(2015, 3, 1), 50000, cargos.Ingeniero);
empleados[1] = new SisPersonal("Maria", "Gomez", new DateTime(1985, 8, 20), 'C', new DateTime(2010, 6, 15), 60000, cargos.Especialista);
empleados[2] = new SisPersonal("Carlos", "Lopez", new DateTime(1975, 12, 10), 'C', new DateTime(2000, 1, 20), 70000, cargos.Administrativo);

double MontoTotal = 0;
for (int i = 0; i < empleados.Length; i++)
{
    MontoTotal += empleados[i].CalcularSalario();
}
Console.WriteLine($"El monto total a pagar por los tres empleados es: {MontoTotal}");

