class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario("isabella", "eng de software", 25000);
        funcionario.MostrarInfo();


        Gerente gerente = new Gerente("cintia", 42000);
        gerente.MostrarInfo();
    }
}