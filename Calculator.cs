//In the name of Allah

namespace Calculator.UserDefiendClasses;

public class CalculatorController
{
    public double sum(double x,double y){
        return x + y;
    }//func
    public double subtract(double x,double y){
        if(x < y){
            swap(ref x,ref y);
            return x - y;
        }else{
            return x - y;
        }//else
    }//func
    public void swap(ref double x,ref double y){
        var temp = x;
        x = y;
        y = temp;
    }//func
}//class