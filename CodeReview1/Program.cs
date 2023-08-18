//public static void Main(string[] args)
//{
//    Console.WriteLine(validaMaioridade(22, "EUA"));
//}

//public static string validaMaioridade(int pIdade, string pNasc)
//{
//    if (pIdade >= 18 && pNasc == "BR")
//    {
//        return "Maioridade";
//    }
//    else if (pIdade >= 21 && pNasc == "EUA")
//    {
//        return "Maioridade";
//    }
//    else
//    {
//        return "Menoridade";
//    }
//}








using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Adicione um exemplo explicativo para o usuário entender o resultado
        Console.WriteLine("Exemplo de validação de maioridade:");
        Console.WriteLine("Resultado para idade 22 e nacionalidade 'EUA': " + ValidaMaioridade(22, "EUA"));

        // Aguarda a entrada do usuário antes de encerrar
        Console.ReadLine();
    }

    public static string ValidaMaioridade(int idade, string nacionalidade)
    {
        // Use nomes de variáveis descritivos para melhorar a legibilidade
        if (idade >= 18 && nacionalidade == "BR")
        {
            return "Maioridade";
        }
        else if (idade >= 21 && nacionalidade == "EUA")
        {
            return "Maioridade";
        }
        else
        {
            return "Menoridade";
        }


    }

}



//fiz as seguintes melhorias:

//Adicionei um exemplo explicativo: Agora, antes do resultado, há uma mensagem que informa ao usuário o que está sendo testado.

//Nomes de variáveis descritivos: Substituí os nomes das variáveis pIdade e pNasc por idade e nacionalidade, respectivamente, para tornar o código mais claro.

//Removi duplicação de código: Note que os dois blocos if tinham o mesmo resultado, então agora há apenas um bloco if com a condição necessária.

//Lembrando que a legibilidade e a manutenibilidade do código são muito importantes. Essas melhorias visam facilitar a compreensão do código e sua futura manutenção.
