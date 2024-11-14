namespace CollectionKlasserDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FIFO - first in - first out
            Queue<string> enQueue = new();
            enQueue.Enqueue("1");
            enQueue.Enqueue("2");
            enQueue.Enqueue("3");
            enQueue.Enqueue("4");

            string enKøVærdi = enQueue.Dequeue();

            while (enQueue.TryDequeue(out enKøVærdi))
            {
                if (enKøVærdi == "4")
                {
                    break;
                }
            }

            //LIFO - last in - first out
            Stack<string> enStack = new();
            enStack.Push("Første");
            enStack.Push("Anden");
            enStack.Push("Tredje");
            enStack.Push("Fjerde");
            enStack.Push("Femte");

            //string enVaerdi = enStack.Pop();
            string poppedVaerdi = null;
            while (enStack.TryPop(out poppedVaerdi))
            {
                Console.WriteLine(poppedVaerdi);
            }

            int a = 20;
            int b = 10;

            Swap(ref a, ref b);
        }

        public static void Swap(ref int a, ref int b) 
        {
            int tmp = b;
            b = a;
            a = tmp;
        
        }
    }
}
