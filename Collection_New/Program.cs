namespace Collection_New
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Collection Problem");

            CollectionSamples Collection = new CollectionSamples();
            Collection.setDemo();
            Collection.doListDemo();
            Collection.doStackDemo();
            Collection.doDictionaryDemo();
            Collection.doQueueDemo();
        }
    }
}