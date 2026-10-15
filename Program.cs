using System;
using aulas_git_114_2;

class Program
{
    static void Main()
    {
        var login = new Login
        {
            Usuario = "admin",
            Senha = "1234"
        };

        if (login.Autenticar())
        {
            Console.WriteLine("Autenticação bem-sucedida.");
        }
        else
        {
            Console.WriteLine("Falha na autenticação.");
        }
    }
}