namespace Core.Entities;

public abstract class Test : Person
{
    public Test(string name, byte age) : base(name, age)
    {
    }

    //public abstract string B();

    public override void Eat()
    {
        Console.WriteLine("");
    }

    /// <summary>
    /// Iki ededi toplayir
    /// </summary>
    /// <param name="a">toplacaq birinci eded</param>
    /// <param name="b">toplacaq ikinci eded</param>
    /// <returns></returns>
    public int Sum(int a, int b)
    {
        return a + b; 
    }
}
