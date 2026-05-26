namespace CalculadoraEspacio;

class Calculadora
{
    double numero1;
    double numero2;
    public double GetNumero1()
    {
        return numero1;
    }
    public double GetNumero2()
    {
        return numero2;
    }
    public void SetNumero1(double numero1)
    {
        this.numero1 = numero1;
    }
    public void SetNumero2(double numero2)
    {
        this.numero2 = numero2;
    }
    public double Sumar(double numero1, double numero2)
    {
        double resultado = numero1 + numero2;
        return resultado;
    }
    public double Restar(double numero1, double numero2)
    {
        double resultado = numero1 - numero2;
        return resultado;
    }
    public double Multiplicar(double numero1, double numero2)
    {
        double resultado = numero1 * numero2;
        return resultado;
    }
    public double Dividir(double numero1, double numero2)
    {
        double resultado = numero1 / numero2;
        return resultado;
    }
    public void Limpiar() { }
}