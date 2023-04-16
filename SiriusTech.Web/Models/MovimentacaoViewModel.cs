using SiriusTech.Data.Models;

namespace SiriusTech.Web.Models
{
    public class MovimentacaoViewModel
    {    
        public Entidade entidade { get; set; }        
        public TipoMovimentacao tipoMovimentacao { get; set; }
        public Movimentacao movimentacao { get; set; }

        public List<Entidade> listEntidade { get; set; }
        public List<TipoMovimentacao> listTipoMovimentacao { get; set; }
    }
}
