public class fraction ()
{
    private int _top;
    private int _bottom;

    public fraction ()
    {
        _top = 1;
        _bottom = 1;
    }

    public fraction ( int wholeNumber)
    {
        _top =wholeNumber;
        _bottom= 1 ;
    }

    private fraction (int top, int bottom)
    {

        _top = top;
        _bottom = bottom;
    }


   
    public GetTop (){
        return _top;
    }
    public SetTop( int _top){
        _top = top;
    }
    public GetBottom (){
        return _bottom;
    }
    public SetBottom (int _bottom){
        _bottom = bottom;
    }
    
    
    public string GetFractionString ()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue (){
        return (double)_top/(double)_bottom;
    }
}