using System.Diagnostics;

public class Fraction {
    
    public int _top = 0;
    public int _bottom = 0;


    public int GetTop(){
        return _top;
    }

    public void SetTop(int TopNumber){
        _top = TopNumber;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int Bottom){
        _bottom = Bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top/_bottom;
    }

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int TopNumber){
        _top=TopNumber;
        _bottom = 1;
    }

    public Fraction(int TopNumber, int BottomNumber){
        _top=TopNumber;
        _bottom=BottomNumber;
    }


}