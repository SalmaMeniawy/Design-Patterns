using System;
public interface Product{
    void doStuff();
}
public class ConcreteProductA : Product{
   public void doStuff(){
        Console.WriteLine("Hello From Product A \n");
    }
}
public class ConcreteProductB : Product{
    public void doStuff()
    {
        Console.WriteLine("Hello From Product B \n");
    }
}
 public abstract class Creater {
    protected Product product;
    public void someOperation()
    {
        Console.WriteLine("Hello From creator \n");

    }
   public abstract Product createProduct();
}
public class ConcreteCreatorA : Creater{
    public override Product createProduct()
    {
        this.product = new ConcreteProductA();
        this.product.doStuff();
        return this.product;
    }
}
public class ConcreteCreatorB : Creater{
    public override Product createProduct()
    {
        this.product = new ConcreteProductB();
        this.product.doStuff();
        return this.product;
    }
}
public class Application
{

   
    static void Main(string [] args)
   {
        Creater creater;
       Console.WriteLine("Choose product A OR B");
        string action = Console.ReadLine();
        if(action == "A")
        {
            creater = new ConcreteCreatorA();
            creater.createProduct();
        }
        if(action == "B")
        {
            creater = new ConcreteCreatorB();
            creater.createProduct();
        }

   }
   

}