using Empleados;
    Empleado[] empleados = new Empleado[3];
    empleados[0] = new Empleado("Ana", "Lopez", new DateTime(1980, 4, 15), 'C',
                                    new DateTime(2005, 6, 1), 600000, Cargos.Ingeniero);

    empleados[1] = new Empleado("Luis", "Martinez", new DateTime(1975, 10, 23), 'S',
                                    new DateTime(2010, 3, 10), 550000, Cargos.Administrativo);

    empleados[2] = new Empleado("Maria", "Perez", new DateTime(1990, 1, 5), 'C',
                                    new DateTime(2015, 9, 12), 650000, Cargos.Especialista);
        double totalSalarios = 0;
        Empleado proximoJubilado = empleados[0];
        Console.WriteLine("=== INFORMACIÓN DE EMPLEADOS ===\n");
        foreach (Empleado e in empleados)
        {
            e.MostrarInformacionCompleta();
            totalSalarios += e.Salario;

            if (e.AñosParaJubilarse < proximoJubilado.AñosParaJubilarse)
                proximoJubilado = e;
        }
        Console.WriteLine($"\nMonto total: ${totalSalarios:F2}");
        Console.WriteLine("\n=== Empleado mas proximo a jubilarse ===\n");
        proximoJubilado.MostrarInformacionCompleta();

