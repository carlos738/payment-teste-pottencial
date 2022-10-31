using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Models
{
    public class Compras
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public int IdVendedor { get; set; }
        public Vendas Venda { get; set; }
        public Vendedores Vendedor { get; set; }
        
        
        
        
        
        
        
    }
}