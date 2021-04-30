using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiberianSales2.Models;

namespace SiberianSales2.Data
{
    public class SeedingService
    {
        private SiberianSales2Context _context;

        public SeedingService(SiberianSales2Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesOrder.Any() ||
                _context.Address.Any() ||
                _context.ProposalStatus.Any() ||
                _context.SalesOrderStatus.Any() ||
                _context.PurchaseOrderStatus.Any() ||
                _context.ComissionStatus.Any() ||
                _context.ProductType.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Hardware");
            Department d2 = new Department(2, "Software");
            Department d3 = new Department(3, "Services");

            Address a1 = new Address { Id = 1, AddressName = "Rua Calaguala", AddessNumber = "92", AddressComplement = "", District = "Jardim Eliane", City = "São Paulo", State = "São Paulo", PostalCode = "03578140" };

            Address a2 = new Address { Id = 2, AddressName = "Rua Serra de Botucatu", AddessNumber = "880", AddressComplement = "Sala 608, 6º andar", District = "Vila Gomes Cardim", City = "São Paulo", State = "São Paulo", PostalCode = "03317-000" };

            Address a3 = new Address { Id = 3, AddressName = "Av. Marques de São Vicente", AddessNumber = "587", AddressComplement = "Sala 9", District = "Várzea da Barra Funda", City = "São Paulo", State = "São Paulo", PostalCode = "01139-001" };

            Reseller r1 = new Reseller { Id = 1, AddressId = 1, ResellerCnpj = "34.868.246/0001-00", MunicipalInscription = "6.396.070-2", ResellerName = "VB E CG COMERCIO E SERVICOS DE INFORMATICA LTDA", ResellerFantasyName = "Siberian Tech Informática", Phone = "11 2367-0528", StateInscription = "126.757.721.115", TxComissionRetention = 0.00, Website = "http://www.siberiantech.com.br" };

            Seller s1 = new Seller { Id = 1, Name = "Cristiane Gomes de Lima Barauskas", Email = "cristiane@siberiantech.com.br", BirthDate = new DateTime(1982,2,6), DepartmentId = 1, Phone = "11988972760", Skype = "victor.barauskas@hotmail.com" , BaseSalary = 4000.00, ResellerId = 1};
            Seller s2 = new Seller { Id = 2, Name = "Victor Barauskas Bezerra da Silva", Email = "victor@siberiantech.com.br", BirthDate = new DateTime(1987,11,21), DepartmentId = 2, Phone = "11988879345", Skype = "crisgomeslima", BaseSalary = 4000.00, ResellerId = 1 };

            ProductType pt1 = new ProductType(1, "Desktops");
            ProductType pt2 = new ProductType(2, "Notebooks");
            ProductType pt3 = new ProductType(3, "Monitores");
            ProductType pt4 = new ProductType(4, "VGAs");
            ProductType pt5 = new ProductType(5, "Network");
            ProductType pt6 = new ProductType(6, "Softwares");
            ProductType pt7 = new ProductType(7, "Processadores");
            ProductType pt8 = new ProductType(8, "Motherboards");
            ProductType pt9 = new ProductType(9, "Memórias");
            ProductType pt10 = new ProductType(10, "Armazenamento");
            ProductType pt11 = new ProductType(11, "Energia");
            ProductType pt12 = new ProductType(12, "Fontes de Alimentação");
            ProductType pt13 = new ProductType(13, "Gabinetes");
            ProductType pt14 = new ProductType(14, "Acessórios");
            ProductType pt15 = new ProductType(15, "Serviços");

            ProposalStatus ps1 = new ProposalStatus(1, "Enviada");
            ProposalStatus ps2 = new ProposalStatus(2, "Analisando");
            ProposalStatus ps3 = new ProposalStatus(3, "Aceita");
            ProposalStatus ps4 = new ProposalStatus(4, "Declinada");
            ProposalStatus ps5 = new ProposalStatus(5, "Cancelada");
            ProposalStatus ps6 = new ProposalStatus(6, "Vencida");

            ComissionStatus cs1 = new ComissionStatus(1, "AguardandoPgto");
            ComissionStatus cs2 = new ComissionStatus(2, "Paga");

            SalesOrderStatus sos1 = new SalesOrderStatus(1, "Enviada");
            SalesOrderStatus sos2 = new SalesOrderStatus(2, "Faturada");
            SalesOrderStatus sos3 = new SalesOrderStatus(3, "Recebida");
            SalesOrderStatus sos4 = new SalesOrderStatus(4, "Comissionando");
            SalesOrderStatus sos5 = new SalesOrderStatus(5, "Finalizado");
            SalesOrderStatus sos6 = new SalesOrderStatus(6, "Cancelado");

            PurchaseOrderStatus pos1 = new PurchaseOrderStatus(1, "Solicitado");
            PurchaseOrderStatus pos2 = new PurchaseOrderStatus(2, "Faturado");
            PurchaseOrderStatus pos3 = new PurchaseOrderStatus(3, "Recebido");
            PurchaseOrderStatus pos4 = new PurchaseOrderStatus(4, "Finalizado");
            PurchaseOrderStatus pos5 = new PurchaseOrderStatus(5, "Cancelado");

            _context.Department.AddRange(d1, d2, d3);
            _context.Address.AddRange(a1, a2, a3);
            _context.Reseller.AddRange(r1);
            _context.Seller.AddRange(s1, s2);
            _context.ProductType.AddRange(pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9, pt10, pt11, pt12, pt13, pt14, pt15);
            _context.ProposalStatus.AddRange(ps1, ps2, ps3, ps4, ps5, ps6);
            _context.SalesOrderStatus.AddRange(sos1, sos2, sos3, sos4, sos5, sos6);
            _context.PurchaseOrderStatus.AddRange(pos1, pos2, pos3, pos4, pos5);
            _context.ComissionStatus.AddRange(cs1, cs2);

            _context.SaveChanges();
        }
    }
}
