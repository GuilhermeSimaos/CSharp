using System;
class Empregado{
    //Variaveis
    private float salarioHora;
    private int horasTrabalhadas;
    private float salarioFinal;
    
    private const float inss = .11f;

    //Construtor
    public Empregado(float salarioH, int horasT){
        this.salarioHora = salarioH;
        this.horasTrabalhadas = horasT;
        this.salarioFinal = salarioHora * horasTrabalhadas;
        this.salarioFinal -= (salarioFinal * inss);
    }

    //Getters e Setters
    public float _SalarioHora{get{return this.salarioHora;}set{this.salarioHora = value;}}
    public int _HorasTrabalhadas{get{return this.horasTrabalhadas;}set{this.horasTrabalhadas = value;}}
    public float _SalarioFinal{get{return this.salarioFinal;}set{this.salarioFinal = value;}}

    //Metodo para exibir informacoes sobre o salario
    public void empregadoInfo(){
        Console.Write($"\n------------------ Info ------------------\n\nSalario/Hora ganho: R${this._SalarioHora} reais/hora\nHoras Trabalhadas no mês: {this._HorasTrabalhadas} horas\n");
        Console.Write($"\nDesconto do INSS: R${(this.salarioHora*this.horasTrabalhadas)*inss} - 11%\n\nSalario Estimado: \tR${this.salarioHora*this.horasTrabalhadas}\nSalario Final: \t\tR${this.salarioFinal}\n\n------------------------------------------\n\n");
    }
}