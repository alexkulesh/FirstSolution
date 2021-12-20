namespace Part16Task1
{
    public static class Zoo
    {
        public static void Swim(ISwimable [] swimable)
        {
            for (int i = 0; i < swimable.Length; i++)
            {
                swimable[i].Swim();
            }
        }
    }
}