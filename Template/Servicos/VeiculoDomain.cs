using Exemplo;
using Template.Infra;
using Veiculos;
using Veiculos.DTO;

namespace Servicos
{
    public class VeiculoDomain
    {
        public DataContext _dataContext;

        public VeiculoDomain()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }

        public void Inserir(InserirVeiculoDTO dadosDaInsercao)
        {
            var veiculo = new Veiculo();

            veiculo.Modelo = dadosDaInsercao.Modelo;
            veiculo.Placa = dadosDaInsercao.Placa;
            veiculo.Renavam = dadosDaInsercao.Renavam;
            veiculo.Status = EnumStatusVeiculo.Disponivel;

            if (veiculo.Placa == "")
            {
                throw new Exception("Falta informar a placa do veículo");
            }

            _dataContext.Add(veiculo);

            _dataContext.SaveChanges();
        }

        public void Alterar(int id, EditarVeiculoDTO dadosAlteracao)
        {
            var veiculo = _dataContext.Veiculos.FirstOrDefault(p => p.Id == id);

            veiculo.Modelo = dadosAlteracao.Modelo;
            veiculo.Placa = dadosAlteracao.Placa;
            veiculo.Renavam = dadosAlteracao.Renavam;

            _dataContext.SaveChanges();
        }

        public List<Veiculo> BuscarVeiculos()
        {
            var listaVeiculo = _dataContext.Veiculos.ToList();

            return listaVeiculo;
        }

        public Veiculo BuscarPorId(int id)
        {
            var veiculo = _dataContext.Veiculos.FirstOrDefault(p => p.Id == id);

            return veiculo;
        }

        public void AlterarStatus(int id, AlterarStatusDTO alteracaoDto)
        {
            var veiculo = _dataContext.Veiculos.FirstOrDefault(p => p.Id == id);

            if (veiculo == null)
            {
                throw new Exception("Veículo inválido");
            }

            veiculo.Status = alteracaoDto.Status;

            _dataContext.SaveChanges();
        }
    }
}
