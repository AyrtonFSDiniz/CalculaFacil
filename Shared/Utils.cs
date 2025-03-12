using System;
using System.Globalization;

public static class Utils
{
    // Cultura do Brasil (pt-BR)
    private static readonly CultureInfo CulturaBrasil = new CultureInfo("pt-BR");

    // Formata um número no formato brasileiro (ex: 1.234.567,89)
    public static string FormatarNumero(decimal numero, int casasDecimais = 2)
    {
        return numero.ToString($"N{casasDecimais}", CulturaBrasil);
    }

    // Formata um valor monetário no formato brasileiro (ex: R$ 1.234.567,89)
    public static string FormatarMoeda(decimal valor, int casasDecimais = 2)
    {
        return valor.ToString($"C{casasDecimais}", CulturaBrasil);
    }

    // Converte uma string para decimal (considerando o formato brasileiro)
    public static decimal ConverterParaDecimal(string numeroString)
    {
        if (decimal.TryParse(numeroString, NumberStyles.Number, CulturaBrasil, out decimal numeroDecimal))
        {
            return numeroDecimal;
        }
        throw new FormatException("Formato de número inválido.");
    }

    // Formata uma data no formato brasileiro (ex: 31/12/2023)
    public static string FormatarData(DateTime data)
    {
        return data.ToString("dd/MM/yyyy", CulturaBrasil);
    }

    // Formata uma data e hora no formato brasileiro (ex: 31/12/2023 23:59:59)
    public static string FormatarDataHora(DateTime dataHora)
    {
        return dataHora.ToString("dd/MM/yyyy HH:mm:ss", CulturaBrasil);
    }

    // Remove caracteres não numéricos de uma string (ex: "R$ 1.234,56" → "1234.56")
    public static string RemoverCaracteresNaoNumericos(string input)
    {
        return new string(input.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
    }

    // Formata um CPF (ex: 12345678901 → 123.456.789-01)
    public static string FormatarCPF(string cpf)
    {
        if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            throw new ArgumentException("CPF inválido.");

        return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
    }

    // Formata um CNPJ (ex: 12345678000199 → 12.345.678/0001-99)
    public static string FormatarCNPJ(string cnpj)
    {
        if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
            throw new ArgumentException("CNPJ inválido.");

        return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";
    }

    // Formata um telefone (ex: 11987654321 → (11) 98765-4321)
    public static string FormatarTelefone(string telefone)
    {
        if (string.IsNullOrEmpty(telefone) || telefone.Length < 10 || telefone.Length > 11)
            throw new ArgumentException("Telefone inválido.");

        if (telefone.Length == 10) // Telefone fixo
        {
            return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)}-{telefone.Substring(6, 4)}";
        }
        else // Celular
        {
            return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
        }
    }
}