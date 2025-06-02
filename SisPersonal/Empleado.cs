namespace Empleados {public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; }  // 'C' = Casado, 'S' = Soltero, etc.
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil,
                    DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }

    public int Antiguedad
    {
        get
        {
            int años = DateTime.Today.Year - FechaIngreso.Year;
            if (DateTime.Today < FechaIngreso.AddYears(años)) años--;
            return años;
        }
    }

    public int Edad
    {
        get
        {
            int años = DateTime.Today.Year - FechaNacimiento.Year;
            if (DateTime.Today < FechaNacimiento.AddYears(años)) años--;
            return años;
        }
    }

    public int AñosParaJubilarse
    {
        get
        {
            int añosRestantes = 65 - Edad;
            return añosRestantes > 0 ? añosRestantes : 0;
        }
    }

    public double Salario
    {
        get
        {
            double adicional;

            if (Antiguedad <= 20)
                adicional = SueldoBasico * (0.01 * Antiguedad);
            else
                adicional = SueldoBasico * 0.25;

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                adicional *= 1.5;

            if (char.ToUpper(EstadoCivil) == 'C')
                adicional += 150000;

            return SueldoBasico + adicional;
        }
    }

    public void MostrarInformacionCompleta()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Antigüedad: {Antiguedad} años");
        Console.WriteLine($"Años para jubilarse: {AñosParaJubilarse}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Sueldo Básico: ${SueldoBasico:F2}");
        Console.WriteLine($"Salario Calculado: ${Salario:F2}");
        Console.WriteLine("----------------------------------------");
    }
}}
