namespace ProjetoDesafioObj.Domins
{
    public class Prato
    {
        public string Nome { get; set; }
        public bool EMassa { get; set; }

        public Prato(string nome, bool eMassa)
        {
            Nome = nome;
            EMassa = eMassa;
        }
    }
}
