using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace SkiServiceManagement.Models
{
    public class Serviceauftrag
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // MongoDB ObjectId as string
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string KundenName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Telefon { get; set; }

        [Required]
        [MaxLength(30)]
        public string Prioritaet { get; set; }

        [Required]
        [MaxLength(250)]
        public string Dienstleistung { get; set; }

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime PickupDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Status { get; set; } = "Offen";
    }
}
