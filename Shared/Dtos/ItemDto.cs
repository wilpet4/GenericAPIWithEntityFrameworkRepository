using Shared.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public class ItemDto : DataTransferObject
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        public int Price { get; set; }
    }
}
