namespace SourceCodePrettyHair
{
    public class Customer

    {
        public int Id;
        public string Name;
        public string Adresse;
 

        public Customer()
        {

        }
        public Customer(int id, string name, string adresse)
        {
            Id = id;
            Name = name;
            Adresse = adresse;

        }
        public Customer(int id)
        {
            Id = id;
        }


    }
}