using System.ComponentModel;

namespace FriendZone.Entities
{
    public class Contact
    {
        /*
         * design Contact model with properties for
         * ContactId, FirstName, LastName, ContactNo, Email, BirthDate, Address, City, Pincode, BloodGroup, CreationDate
        */

        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string  BirthDate { get; set; }

        public string Address { get; set; }

        public string   City { get; set; }

        public string Pincode { get; set; }

        public string BloodGroup { get; set; }

        public string CreationDate { get; set; }

    }
}
