﻿namespace UrphaCapital.Domain.Entities
{
    public class ClickTransaction
    {
        public int Id { get; set; }
        public long ClickTransId { get; set; }
        public string MerchantTransId { get; set; }
        public decimal Amount { get; set; }
        public string SignTime { get; set; }
        public int? Situation { get; set; }
        public EOrderPaymentStatus Status { get; set; }
    }
}
