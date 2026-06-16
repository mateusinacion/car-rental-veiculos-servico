namespace Veiculos
{
    public class Veiculo
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

        public EnumStatusVeiculo Status { get; set; }
    }

    public enum EnumStatusVeiculo
    {
        Disponivel = 1,
        Indisponivel = 2
    }
}
