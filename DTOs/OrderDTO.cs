using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.DTOs
{
    public class OrderDTO
    {
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public List<OrderItemDTO> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }
    }
}