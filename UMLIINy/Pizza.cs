namespace UMLIINy
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Nummer: {Number}, Navn: {Name}, Pris: {Price}";
        }
    }
}
    

