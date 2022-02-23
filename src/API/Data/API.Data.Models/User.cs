using API.Data.Common.Models;
using System.Text.Json.Serialization;

namespace API.Data.Models
{
    public class User : IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }

        [JsonIgnore]
        public string? PasswordHash { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}