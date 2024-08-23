

// int Soma (int a, int b)
// {
//     return a + b;
// }
// Console.WriteLine(Soma(2,5));

int maior (int[] valores)
{

    for (int i = 0; i < valores.Length; i++)
    {
        
        if (maior < valores[i])
        {
            maior = valores[i];
        }
    }
    return maior;
}
Console.WriteLine("O maior valor é: " + maior);

//-------------------------------------------------------
string palavra = Console.ReadLine();

Console.WriteLine (palavra.ToUpper);


// class Program
// {

// static void Main()
// {

// Carro carro1 = new Carro("Fusca", "ABC-1234", "Azul", 1000);
// Carro carro2 = new Carro("Gol", "DEF-5678", "Preto", 2000);
// Carro carro3 = new Carro("Celta", "GHI-9101", "Branco", 3000);

// Console.WriteLine(carro1.possoBaterNoMeuAmigo());
// Console.WriteLine(carro2.possoBaterNoMeuAmigo());
// Console.WriteLine(carro3.possoBaterNoMeuAmigo());
// }


// class Carro 
// { 
//     string nome;
//     string placa;
//     string cor;
//     double kmrodados; 


// public Carro(string nome, string placa, string cor, double kmrodados)
// {
//     this.nome = nome;
//     this.placa = placa;
//     this.cor = cor;
//     this.kmrodados = kmrodados;

// }

// public bool possoBaterNoMeuAmigo()

// {
//    if(this.nome == "Fusca" && this.cor == "Azul" )
//    { 
//       return true;
//    }
//    else
//    {
//     return false;
//    }


// }
// }
// }



