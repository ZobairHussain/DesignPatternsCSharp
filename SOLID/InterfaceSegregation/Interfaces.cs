public interface IMachine
{
    void Print(Document d);
    void Fax(Document d);
    void Scan(Document d);
}
public interface IPrinter
{
    void Print(Document d);
}

public interface IScanner
{
    void Scan(Document d);
}
public interface IMultiFunctionDevice : IPrinter, IScanner
{

}
