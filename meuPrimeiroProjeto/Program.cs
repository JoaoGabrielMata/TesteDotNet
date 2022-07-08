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
      ContaCorrente conta_do_Guilherme = new ContaCorrente("Guilherme",444, 247,0);
        Console.WriteLine("O saldo do "+conta_do_Joao.Titular +" era: "+conta_do_Joao.Saldo +" reais.");
        Console.WriteLine("O saldo do "+conta_da_Sabrina.Titular +" era: "+conta_da_Sabrina.Saldo +" reais.");
        Console.WriteLine("O saldo do "+conta_da_Jaqueline.Titular +" era: "+conta_da_Jaqueline.Saldo +" reais.");
        Console.WriteLine("O saldo do "+conta_do_Guilherme.Titular +" era: "+conta_do_Guilherme.Saldo +" reais.");
      bool Sacar_conta1 = conta_do_Joao.Sacar(30);
      bool Depositar_conta2 = conta_da_Sabrina.Depositar(70);
      bool Sacar_conta3 = conta_da_Jaqueline.Sacar(50);
      bool Depositar_conta4 = conta_do_Guilherme.Depositar(20);
        Console.WriteLine("A conta é do(a) "+ conta_do_Joao.Titular +". O saldo agora é : "+conta_do_Joao.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_da_Sabrina.Titular +". O saldo agora é : "+conta_da_Sabrina.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_da_Jaqueline.Titular +". O saldo agora é : "+conta_da_Jaqueline.Saldo+" reais.");
        Console.WriteLine("A conta é do(a) "+ conta_do_Guilherme.Titular +". O saldo agora é : "+conta_do_Guilherme.Saldo+" reais.");
    } 
  }  
}