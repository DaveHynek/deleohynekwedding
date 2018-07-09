using System.ComponentModel.DataAnnotations;

namespace deleohynekwedding.Models
{
    public class Guest
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public GuestResponseInfo ResponseInfo { get; set; }

        internal void Map(Guest guest)
        {
            LastName = guest.LastName;
            FirstName = guest.FirstName;
            Email = guest.Email;

            if (guest.ResponseInfo == null) return;
            if (ResponseInfo == null) ResponseInfo = new GuestResponseInfo();
            ResponseInfo.Map(guest.ResponseInfo);
        }
    }
}
