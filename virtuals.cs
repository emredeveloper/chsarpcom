namespace recapdemo
{
    class Program
{
 
    static void Main(string[]args)
    {

        sqlserver sql = new sqlserver();
        sql.ekle();
        sql.guncelleme();
        
        oracleserver oracle = new oracleserver();
        oracle.ekle();
        oracle.guncelleme();

    }
    
}

class dataveri{
    public virtual void ekle()
    {
        System.Console.WriteLine("Eklendi!");

    }
    public virtual  void sil()
    {
        System.Console.WriteLine("Silindi!");

    }
    public virtual void guncelleme()
    {
        System.Console.WriteLine("Güncelle");
    }
}
class sqlserver : dataveri
{

    public override void ekle()
    {
        System.Console.WriteLine("Sql eklendi!");
    }



}

class oracleserver : dataveri
{
    public override void guncelleme()
    {
        System.Console.WriteLine("Oracle Güncelenemedi!!!");
    }

}

}