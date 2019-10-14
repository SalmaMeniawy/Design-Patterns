using System;
using System.Collections.Generic;
public interface Strategy{
    int execute(int a , int b);
}
public class ConcreateStrategyAdd : Strategy{
  public  int execute (int a , int b)
    {
        return a + b;
    }
}
public class ConcreateStrategySubtract : Strategy {
   public int execute (int a , int b)
    {
        return a - b;
    }
}
public class ConcreateStrategyMultibly : Strategy {
    public int execute (int a , int b)
    {
        return a * b;
    }
}
public class Context {
    private Strategy strategy;
    public void setStrategy(Strategy strategy)
    {
        this.strategy = strategy;
        
    }
    public int  executeStrategy(int a , int b)
    {
         return this.strategy.execute(a,b);
    }
}
class ExampleApplication {
    static void Main(string [] args)
    {
        Console.Write("Enter a value of 'a' - ");
       string a_input = Console.ReadLine();
       int a = Convert.ToInt32(a_input);
        Console.Write("Enter a value of 'b' - ");
        string b_input = Console.ReadLine();
        int b = Convert.ToInt32(b_input);
         //read action from user
        Console.Write("Chose the action and enter one of the following ");
        Console.Write("addition \n");
        Console.Write("subtraction \n");
        Console.Write("multiply \n");
        string action = Console.ReadLine();
        ///////////////////////////
        Context context = new Context();
        if(action == "addition")
        {
            context.setStrategy(new ConcreateStrategyAdd());
        }
        if(action == "subtraction")
        {
            context.setStrategy(new ConcreateStrategySubtract());
        }
        if(action == "multiply")
        {
            context.setStrategy(new ConcreateStrategySubtract());
        }

        int result = context.executeStrategy(a,b);
        Console.WriteLine(result);
    }
}