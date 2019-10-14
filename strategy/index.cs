// using System;
interface Strategy
{
    int execute(int a,int b);
}
 public class ConcreteStrategyAdd : Strategy
 {
     public int execute(int a,int b)
     {
         return a + b;
     }
 }
 public class ConcreteStrategySubtract:Strategy
 {
     int execute(int a,int b)
     {
         return a - b;
     }
 }
 public class ConcreteStrategyMultiply:Strategy
 {
     public int execute( int a, int b)
     {
        return(a * b);
     }
 }
 public class Client
 {
     private Strategy strategy = new Strategy();
     public void setStrategy(Strategy strategy)
     {
         this.strategy = strategy;
     }
     public void executeStrategy(int a , int b)
     {
         this.strategy.execute(a,b);
     }
 }
 public class ExampleApplication
 {
     public static void Main()
     {
         //create context action
         context = new context();
         int a = 2 ;
         int b = 5 ;
         action = new ConcreteStrategyAdd(a,b);
          
         context.setStrategy(action);
        //  if(action == new ConcreteStrategyAdd)
        //  {
        //      context.setStrategy(action);
        //      System.Console.WriteLine("hello from instance");
        //  }
        // return 0;
     }
 }