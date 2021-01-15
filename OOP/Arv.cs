namespace OOP
{
    internal class Arv1
    {
        public string Name { get; set; }
    }
    internal class Arv2 : Arv1
    {
        public int Age { get; set; }
    }
    internal class Arv3 : Arv2
    {
        public string Adress { get; set; }
    }
}