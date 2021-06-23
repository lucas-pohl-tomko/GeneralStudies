using System;

class MainClass {

  public double knockbackCalculator(double s,double w,ref double p,double d,double b) {
    double knockback =  (s / 100) * ( ( 14*(p+d)*(d+2) / (w+100) )+18 ) +b;
    p = aplyDamage(p,d);
    return knockback;
  }

  public double aplyDamage(double p, double damage) {
    return p += damage;
  }
  
  public static void Main (string[] args) {

    // s = o escalamento do knockback da hitbox
    // p = multiplicador de dano que o alvo possui (antes do dano ser adicionado)
    // d = dano da hitbox
    // w = peso do alvo
    // b = knockback base da hitbox

    
    double s = 40;
    double w = 100;
    double p = 10;
    double d = 40;
    double b = 50;
    
    var t = new MainClass();

    
		Console.WriteLine("knockback é {0}",t.knockbackCalculator(s,w,ref p,d,b));
		Console.WriteLine("knockback é {0}",t.knockbackCalculator(s,w,ref p,60,b));
		Console.WriteLine("knockback é {0}",t.knockbackCalculator(s,w,ref p,d,b));
		Console.WriteLine("knockback é {0}",t.knockbackCalculator(s,w,ref p,d,b));

  }
  
}

