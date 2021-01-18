using System;
class JurosCompostos {
  static void Main(string[] args) {
      
    Console.Write("Capital inicial: ");
    double capital = Convert.ToDouble(Console.ReadLine());
    Console.Write("Taxa de Juros: ");
    double juros = Convert.ToDouble(Console.ReadLine());
    Console.Write("Parcelas: ");
    int tempo = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    
    juros = (juros/100);
    
    do {
    double montante = (capital * Math.Pow((1 + juros),i));
    double jurosCom = (montante - capital);
    double capital1 = (capital*juros*i)+capital;
    Console.WriteLine(i + "º mês | Montante: " + montante + " | Juros Total: " + jurosCom + " | Capital: " + capital1);
    i++;    
    }
    while (i<=tempo);
    
    
    
  }
}





