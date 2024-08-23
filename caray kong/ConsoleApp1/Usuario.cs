using System.Diagnostics.Contracts;

class Usuario 
{

  int id;
  string nome;
  string senha;


public Usuario(int id, string nome, string senha)
{
    
   Random valor = new Random();
   this.nome = nome;
   this.id = valor.Next();
   this.senha = senha;

}

}