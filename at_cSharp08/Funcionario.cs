using System;

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal SalarioAntes { get; set; }

    public Funcionario(string nome, string cargo, decimal salarioantes)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioAntes = salarioantes;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioAntes;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine("Salario: R$ " + CalcularSalario().ToString("F2")
);
    }
}


class Gerente : Funcionario
{
    public Gerente(string nome, decimal salarioantes)
        : base(nome, "Gerente", salarioantes) { }

    public override decimal CalcularSalario()
    {
        return SalarioAntes * 1.2m; 
    }
}