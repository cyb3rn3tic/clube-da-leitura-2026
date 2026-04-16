using System;
using ClubeDaLeitura.ConsoleApp.Dominio;

namespace ClubeDaLeitura.ConsoleApp.Repositorio;

public class RepositorioCaixa
{
    private Caixa?[] caixas = new Caixa[100];

    public void Cadastrar (Caixa nova Caixa)
    {
        for (int i = 0; i< caixas.Length; i++)
        {
            Caixa? c = caixas[i];
            if(c == null)
            {
                Caixa[i] = novaCaixa;
                break;
            }
        }
    }

    public bool Editar (string idSlecionado, Caixa novaCaixa)
    {
        Caixa? caixaSelecionada = SelecionarPorId(IdSelecionado);

        if(caixaSelecionada == null)
        {
            return false;
        }
        
    }
}
