using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace deleohynekwedding.Models
{
    public class Invitation
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string RsvpCode { get; set; }

        public bool? Attending { get; set; }

        public ICollection<Guest> Guests { get; set; }

        internal void Map(Invitation invitation)
        {
            Attending = invitation.Attending;

            if (!Attending.HasValue) return;

            if (!Attending.Value)
            {
                foreach(var guest in Guests)
                {
                    if (guest.ResponseInfo == null) guest.ResponseInfo = new GuestResponseInfo();
                    guest.ResponseInfo.Attending = false;
                }
                return;
            }

            foreach (var guest in Guests)
            {
                guest.Map(invitation.Guests.FirstOrDefault(x => guest.ID == x.ID));
                
            }
        }
    }
}
