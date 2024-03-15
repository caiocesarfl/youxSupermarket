

namespace Vendas.Model
{
    public class Cliente
    {
        public int CategoriaId { get; set; }

        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? UF { get; set; }
        public string? Localizacao { get; set; }
    }
}
