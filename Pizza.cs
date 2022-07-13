namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public string name = "";
        public string description = "";
        public string fotoLink = "";
        public decimal prezzo;

        public Pizza(string name, string description, string fotoLink, decimal prezzo)
        {
            this.name = name;
            this.description = description;
            this.fotoLink = fotoLink;
            this.prezzo = prezzo;
        }

    }
}
