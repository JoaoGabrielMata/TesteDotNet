using System;

namespace meuPrimeiroProjeto
{
  class Program
  {
    static void Main(string[] args) 
    {
      ContaCorrente conta_do_Joao = new ContaCorrente("Joao",111,223,1000); 
      ContaCorrente conta_do_Sabrina = new ContaCorrente("Sabrina",222,233,3000);
      ContaCorrente conta_da_Jaqueline = new ContaCorrente("Jaqueline",333,226,-1000);
        Console.WriteLine("A conta é do(a) "+ conta_do_Joao.Titular + ". A agência é "+ conta_do_Joao.Agencia + ". O número da conta é "+conta_do_Joao.Numero + ". O saldo é de: "+conta_do_Joao.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_do_Sabrina.Titular + ". A agência é "+ conta_do_Sabrina.Agencia + ". O número da conta é "+conta_do_Sabrina.Numero + ". O saldo é de: "+conta_do_Sabrina.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_da_Jaqueline.Titular + ". A agência é "+ conta_da_Jaqueline.Agencia + ". O número da conta é "+conta_da_Jaqueline.Numero + ". O saldo é de: "+conta_da_Jaqueline.Saldo+" reais.");
    } 
  }  
}