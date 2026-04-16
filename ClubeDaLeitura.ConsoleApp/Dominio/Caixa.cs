using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace ClubeDaLeitura.ConsoleApp.Dominio;

public class Caixa
{
    public string Id {get; set;} = string.Empty;
    public string Etiqueta {get; set;} = string.Empty;
    public string Cor {get; set;} = string.Empty;
    public int TempoEmprestimo {get; set;}

    public Caixa(string etiqueta, string cor, int tempoEmprestimo)
    {
        Id= Convert.ToHexString(RandomNumberGenerator.GetBytes(20)).ToLower().Substring(0,7);

        Etiqueta = etiqueta;
        Cor = cor;
        TempoEmprestimo = tempoEmprestimo;    
    }

    public string[] Validar()
    {
        string erros = string.Empty;

        if (string.IsNullOrEmpty(Cor.Trim()))
        {
            erros += "o campo \"Cor\" é obrigatório"; 
        }
        if(string.IsNullOrEmpty(Etiqueta.Trim()))
        {
            erros += "O campo \"Etiqueta\" é obrigatório";
        }
        if(TempoEmprestimo < 1)
        {
            erros += "O campo \"Tempo de empréstimo\" é obrigatório";
        }
        return erros.Split(';', StringSplitOptions.RemoveEmptyEntries);
    }

    public void AtualizarRegistro(Caixa registroAtualizado)
    {
        Etiqueta = registroAtualizado.Etiqueta;
        Cor= registroAtualizado.Cor;
        TempoEmprestimo = registroAtualizado.TempoEmprestimo;
    }
}
