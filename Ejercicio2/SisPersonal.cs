/* 1. Crear una clase Empleado para almacenar la siguiente información:  
a. Nombre (string),  
b. Apellido (string),  
c. Fecha de nacimiento (datetime),  
d. Estado civil (char),
e. Fecha de ingreso en la empresa (datetime),  
f. Sueldo Básico (double),  
g. Cargo (Cargos)  
Nota: Cargo es una variable de tipo “Cargos” que es enumeración (enum) 
que ud debería definir con los siguientes elementos: 
Auxiliar; Administrativo;  Ingeniero; Especialista; Investigador. 
(investigue el uso de  enum en C# para realizar esto)

b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico + 
Adicional. Para ello el Adicional contempla la antigüedad en años, el 
cargo y si es casado: 
i) 1 % del sueldo básico por cada año de antigüedad hasta los 
20 años, a partir de este, el porcentaje se fija en 25%. 
ii) Si el cargo es Ingeniero o Especialista, el Adicional se 
incrementa en un 50%. 
iii)   Si es casado al Adicional se le aumenta $150.000.  
Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico = 
$650.000, el Adicional es 65.0000 * 0.15 = 97.500. Si además el 
cargo es Ingeniero o Especialista, se incrementa el Adicional en 
un 50%. Esto es: 97.500* 1.50 = 146.250. Si a su vez es casado 
el Adicional será: 146.250+ 150.000= 296.250 
 */




namespace Personal;

enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

class SisPersonal
{
    string? nombre;
    string? apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    DateTime fechaIngreso;
    double sueldoBasico;
    Cargos cargo;

    public SisPersonal(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    public string? Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string? Apellido
    {
        get => apellido;
        set => apellido = value;
    }

    public DateTime FechaNacimiento
    {
        get => fechaNacimiento;
        set => fechaNacimiento = value;
    }

    public char EstadoCivil
    {
        get => estadoCivil;
        set => estadoCivil = value;
    }

    public DateTime FechaIngreso
    {
        get => fechaIngreso;
        set => fechaIngreso = value;
    }

    public double SueldoBasico
    {
        get => sueldoBasico;
        set => sueldoBasico = value;
    }

    public Cargos Cargo
    {
        get => cargo;
        set => cargo = value;
    }

    public int AñosRestantesParaJubilarse()
    {
        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        int añosRestantes = 65 - edad;
        return añosRestantes;
    }
    public int AntiguedadEnLaEmpresa()
    {
        int antiguedad = DateTime.Now.Year - fechaIngreso.Year;
        return antiguedad;
    }
    public int Edad()
    {
        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        return edad;
    }
    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = AntiguedadEnLaEmpresa();
        if (antiguedad <= 20)
        {
            adicional += sueldoBasico * 0.01 * antiguedad;
        }
        else
        {
            adicional += sueldoBasico * 0.25;
        }

        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        if (estadoCivil == 'C')
        {
            adicional += 150000;
        }

        return sueldoBasico + adicional;
    }

}