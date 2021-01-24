using System;

namespace Ders_5_Odev_5.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
