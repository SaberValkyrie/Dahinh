using System.Security.Cryptography;

class Gender

{
    static void Main()
    {
        Gender male = new Male();
        Gender female = new Female();
        male.check();
        female.check();
    }
    public virtual void check() { Console.WriteLine("Check Gender"); }
}
class Male : Gender
{ public override void check() { Console.WriteLine("Gender:Male"); } }
class Female : Gender
{ public override void check() { Console.WriteLine("Gender:Female"); } }
