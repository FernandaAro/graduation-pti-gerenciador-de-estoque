using System;
class GerenciadorEstoque
{
    Jogo[] jogos = new Jogo[0];
    public void Adicionar(Jogo novoJogo)
    {
        Jogo[] novoVetor = new Jogo[jogos.Length + 1];
        for (int pos = 0; pos < jogos.Length; pos++)
        {
            novoVetor[pos] = jogos[pos];
        }
        novoVetor[novoVetor.Length - 1] = novoJogo;

        jogos = novoVetor;
    }
    public void Listar()
    {
        Console.WriteLine("\n ---LISTA DE JOGOS---\n");
        for (int pos = 0; pos < jogos.Length; pos++)
        {
            Jogo item = jogos[pos];
            Console.WriteLine($"{pos + 1}. {item.Nome} - {item.Desenvolvedor}, R${item.Preco}, Jogadores: {item.Jogadores}, Plataformas: {item.Plataforma} ({item.Estoque})");
        }
    }
    public void Remover(int posicao)
    {

    }
    public void EntradaEstoque(int posicao, int qtd)
    {

    }
    public void SaidaEstoque(int posicao, int qtd)
    {

    }
}