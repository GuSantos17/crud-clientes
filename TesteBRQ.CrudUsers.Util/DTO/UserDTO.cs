using System.Text.Json.Serialization;

namespace TesteBRQ.CrudUsers.Util.DTO
{
    public class UserDTO
    {
        [JsonPropertyName("id_user")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        
        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("sexo")]
        public string Sexo { get; set; }

        [JsonPropertyName("data_nascimento")]
        public string DataNascimento { get; set; }
    }
}
