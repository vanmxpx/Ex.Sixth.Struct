using System;
namespace Ex.Sixth.Struct
{
    struct Notebook
    {
        private string model;
        private string company;
        private double price;

        public Notebook(string model, string company, double price)
        {
            this.model = model;
            this.company = company;
            this.price = price;
        }

        public void GetContent()
        {
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Company: {0}", company);
            Console.WriteLine("Price: {0}\n", price);
        }
    }
}
