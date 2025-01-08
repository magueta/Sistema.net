

using SVContenedor.Entidades;

namespace SVContenedor.Interfaces
{
    public interface IMedidaContenedor
    {
        Task<List<Medida>> Listar();
    }
}
