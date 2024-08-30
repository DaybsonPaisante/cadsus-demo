using CadsusServiceReference;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadsusServicePortTypeClient client;

            client = new CadsusServicePortTypeClient(CadsusServicePortTypeClient.EndpointConfiguration.CadsusServicePort);

            var clientCredentials = client.ClientCredentials;
            clientCredentials.UserName.UserName = "CADSUS.CNS.PDQ.PUBLICO";
            clientCredentials.UserName.Password = "kUXNmiiii#RDdlOELdoe00966";

            var result = client.pesquisar(
                  new requestPesquisar
                  {
                      FiltroPesquisa = new FiltroPesquisa
                      {
                          CPF = new CPFType
                          {
                              numeroCPF = "66105234368"
                          },
                          tipoPesquisa = TipoPesquisaType.IDENTICA
                      }
                  });

            foreach (var item in result)
            {
                Console.WriteLine(item.NomeCompleto);
            }
        }
    }
}
