

using SVContenedor.Entidades;

namespace SVContenedor.Interfaces
{
    public interface ICategoriaContenedor
    {
     Task<List<Categoria>> Listar(string buscar = "");
     Task<string> Crear(Categoria objeto);
     Task<string> Editar(Categoria objeto);

    }
}
