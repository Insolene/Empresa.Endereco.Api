using Empresa.Endereco.Dominio.Entites;
using Newtonsoft.Json;

namespace Empresa.Endereco.Servico.ViaCep
{
    public class ViaCepService
    {
        //Função assincrona que irá comunicar com o servidor da ViaCep
        public async Task<EnderecoEntity> ObterEnderecoPorCep(string cep)
        {
            //Abrindo uma comunicação de protocolo HTTP para comunicar com outro servidor
            var httpClient = new HttpClient();

            //Executando a operação de requisição para a rota da ViaCep, passando o CEP de forma dinâmica utilizando formatação de string
            var retornoRequisicao = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json");

            //Verificando se a requisição respondeu com sucesso (status code 200)
            if(retornoRequisicao.IsSuccessStatusCode)
            {
                //Deu sucesso, conseguiu comunicar com a ViaCep
                //Obter a informação retornada pela API
                var objetoSerializado = await retornoRequisicao.Content.ReadAsStringAsync();
                //Comando para desserializar o objeto serializado, recuperado do retorno da requisição da ViaCep
                return JsonConvert.DeserializeObject<EnderecoEntity>(objetoSerializado);
            }
            return new EnderecoEntity();
        }
    }
}
