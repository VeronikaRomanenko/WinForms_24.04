namespace WinForms_24._04
{
    public class Tovar
    {
        public string Name { set; get; }
        public string Strana { set; get; }
        public int Zena { set; get; }
        public override string ToString()
        {
            return $"{Name}\t{Strana}\t{Zena.ToString()}";
        }
    }
}