using System.Net.Http.Json;

namespace Servicos
{
    public class CancelarLocacaoVeiculoDTO
    {
        public int VehicleId { get; set; }
    }

    public class LocacaoClient
    {
        public void CancelarLocacoesPorVeiculo(int codigoVeiculo)
        {
            var httpClient = new HttpClient();

            var urlMicrosservico = "http://localhost:5090/";

            var urlManutencao = urlMicrosservico + "rentals/maintenance-status";

            var resultado = httpClient.
                PutAsJsonAsync(urlManutencao, new CancelarLocacaoVeiculoDTO { VehicleId = codigoVeiculo }).Result;

            if (!resultado.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao cancelar locações do veículo");
            }
        }
    }
}
