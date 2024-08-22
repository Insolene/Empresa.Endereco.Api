namespace Empresa.Endereco.Dominio.Entites
{
    public class EnderecoEntity
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string localidade { get; set; }

        public EnderecoEntity()
        {

        }

        public EnderecoEntity(string cep, string logradouro, string localidade)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.localidade = localidade;
        }
    }
}
