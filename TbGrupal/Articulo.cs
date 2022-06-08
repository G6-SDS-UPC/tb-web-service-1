namespace TbGrupal
{
    public class Articulo
    {
        string description;
        double price;
        int code;
        double sell;

        public Articulo(string description, double price, int code, double sell)
        {
            this.Description = description;
            this.Price = price;
            this.Code = code;
            this.Sell = sell;
        }

        public Articulo() { }

        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Code { get => code; set => code = value; }
        public double Sell { get => sell; set => sell = value; }
    }
}
