using System;

namespace meuPrimeiroProjeto
{
  class Program
  {
    static void Main(string[] args) 
    {
      ContaCorrente conta_do_Joao = new ContaCorrente("Joao",111,223,1000); 
      ContaCorrente conta_da_Sabrina = new ContaCorrente("Sabrina",222,233,3000);
      ContaCorrente conta_da_Jaqueline = new ContaCorrente("Jaqueline",333,226,1100);
        Console.WriteLine("O saldo do "+conta_do_Joao.Titular +" era: "+conta_do_Joao.Saldo);
        Console.WriteLine("O saldo do "+conta_da_Sabrina.Titular +" era: "+conta_da_Sabrina.Saldo);
        Console.WriteLine("O saldo do "+conta_da_Jaqueline.Titular +" era: "+conta_da_Jaqueline.Saldo);
      bool Sacar_conta1 = conta_do_Joao.Sacar(30);
      bool Sacar_conta2 = conta_da_Sabrina.Sacar(70);
      bool Sacar_conta3 = conta_da_Jaqueline.Sacar(50);
        Console.WriteLine("A conta é do(a) "+ conta_do_Joao.Titular +". O saldo é de: "+conta_do_Joao.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_da_Sabrina.Titular +". O saldo é de: "+conta_da_Sabrina.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_da_Jaqueline.Titular +". O saldo é de: "+conta_da_Jaqueline.Saldo+" reais.");
    } 
  }  
}