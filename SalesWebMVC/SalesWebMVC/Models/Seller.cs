using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models {
    public class Seller {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }

        //associações
        public Departament Departament { get; set; } //associado com Departamento, ou seja: muitos vendedores são de um departamento ( 1 pra * ou * pra 1)
        public ICollection <SalesRecord> Sales{ get; set; } //instaciado, associado Vendedores com recorde de vendas (1 vendedor pode ter * recorde de vendas).

        //Construtores
        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        //Operação para adicionar uma venda na lista de venda.
        public void AddSalesRecord(SalesRecord sr) {
            Sales.Add(sr);
        
        }

        //Operação para remover uma venda desse vendedor.
        public void RemoveSales(SalesRecord sr) { 
            Sales.Remove(sr);
        }

        //Operação para retornar um total de vendas.
        public double TotalSales(DateTime initial, DateTime final) {

            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount); // filtragem para data inicial e final e assim, calcular a soma das vendas, sr = sales record

        }

    }
}
