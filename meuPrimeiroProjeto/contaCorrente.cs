public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero ;
    public double Saldo;
    public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo)
    {
      this.Titular = Titular;
      this.Numero = Numero;
      this.Agencia = Agencia;
      this.Saldo = Saldo;
    }
}