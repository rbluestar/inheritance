// See https://aka.ms/new-console-template for more information
class Application
{
    //String gallery;
    //String contacts;
    //string files;
        public void Message()
    {
        Console.WriteLine(" message");
    }
    public void call()
    {
        Console.WriteLine(" calling");
    }
    public void Share()
    {
        Console.WriteLine("share documents");
    }
    class wattsup : Application
    {
        public void MessageWattsup()
        {
            Console.WriteLine("Wattsup running");
        }
    }
}
 static void main(string args) {
    Wattsup w = new Wattsup();
    w.Message();
}
