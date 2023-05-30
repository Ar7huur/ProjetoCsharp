using SalesWebMVC.Models.Enums; //import para Sale Status na pasta Enums.

namespace SalesWebMVC.Models {
    public class SalesRecord {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        //associações
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; } //associado a vendedores ou seja, cada recorde de vendas possui um único vendedor.

        //Construtores..
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
