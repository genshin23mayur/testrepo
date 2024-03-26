
class complex{
    private double real;
    private double imag;
    public complex(double real,double imag)
    {
        this.real=real;
        this.imag=imag;
    }
    public static complex operator+(complex c1,complex c2)
    {
        double realsum=c1.real+c2.real;
        double imagsum=c1.imag+c2.imag;
        return complex(realsum,imagsum);
    }
    public void disp()
    {
        Console.WriteLine($"{c.real}+i{c.imag}");
    }
}
public class Program{
    public void main(){
        double real1,imag1,real2,imag2;
        Console.WriteLine("First com num");
        real1=Convert.ToDouble(Console.ReadLine());
        imag1=Convert.ToDouble(Console.ReadLine());
        complex com1=new complex(real1,imag1); 
        Console.WriteLine("sec com num");
        real2=Convert.ToDouble(Console.ReadLine());
        imag2=Convert.ToDouble(Console.ReadLine());
        complex com2=new complex(real2,imag2);
        complex res=com1+com2;
        res.display();
    }
}
