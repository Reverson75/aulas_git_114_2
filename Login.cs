using System;

namespace aulas_git_114_2
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool Autenticar()
        {
            // Lógica de autenticação (exemplo simples)
            if (Usuario == "admin" && Senha == "1234")
            {
                return true;
            }
            return false;
        }
    }
}