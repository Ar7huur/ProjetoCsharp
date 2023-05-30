using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWebMVC.Models {
    public class Departament {
        public int Id { get; set; }
        public string Name { get; set; }

        //associações
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //instaciada e associado departamento com seller ( 1 departamento tem * vendedores)

        //construtores vazios e com arguments.
        public Departament() { }

        public Departament(int id, string name) {
            Id = id;
            Name = name;
        }

        //Operação para adicionar um vendedor.
        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        //Operação para calcular o departamento no intervalo de datas.
        public double TotalSales(DateTime initial, DateTime final) {
            return Sellers.Sum(seller => seller.TotalSales(initial, final)); //calcula a soma das vendas apenas no período de data do módulo total sales. ps: para cada vendedor aplica a função de total sales.

        }

    }
}
