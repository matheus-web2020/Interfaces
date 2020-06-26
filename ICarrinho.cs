namespace InterfacesPOO
{
    public interface ICarrinho
    {
         //CRUD (Create, Read, Update, Delete)


         void Ler();
         void Adicionar(Produto _produto);
         void Remover(Produto _produto);
         void Alterar(Produto _produtoAlterado, int _cod);
         void MostrarTotal();
    }
}