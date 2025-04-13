class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario("isabella", "dev", 25000);
        funcionario.MostrarInfo();


        Gerente gerente = new Gerente("cintia", 42000);
        gerente.MostrarInfo();
    }
}