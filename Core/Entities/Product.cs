using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product 
    {
        //[Key] 
        public int Id { get; set; } //framework va a tomarlo como pk con el nombre por default

        public string Name { get; set; }
    }
}