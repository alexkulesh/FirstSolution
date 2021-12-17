namespace Part16Task1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Penguin penguin1 = new Penguin();
            Penguin penguin2 = new Penguin();
            Makrel makrel = new Makrel();
            Salmon salmon = new Salmon();
            Parrot parrot = new Parrot();
            Zoo.Swim(new ISwimable[]{penguin1, makrel, penguin2, salmon, penguin1});
            Chicken chicken = new Chicken();
            penguin1.Fly(penguin1.Name);
            parrot.Fly(parrot.Name);
            chicken.Fly(chicken.Name);
        }
    }
}