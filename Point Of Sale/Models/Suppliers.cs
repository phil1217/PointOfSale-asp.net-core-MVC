﻿using System.ComponentModel.DataAnnotations;

namespace Point_Of_Sale.Models
{
    public class Suppliers
    {
        [Key]
        public string? SupplierID { get; set; }
        public string? SupplierName { get; set; }
        public string? ContactName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
    }
}
