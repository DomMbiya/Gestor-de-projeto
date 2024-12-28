namespace keisarmindproject.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public UsuarioModel() { }

        public UsuarioModel(int id, string nome, string email)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome)); // Garantir que Nome nunca seja null
            Email = email;
        }
    }
}
