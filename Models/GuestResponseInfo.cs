using System;
using System.ComponentModel.DataAnnotations;

namespace deleohynekwedding.Models
{
    public class GuestResponseInfo
    {
        public int ID { get; set; }
        public bool? Attending { get; set; }

        [StringLength(200)]
        public string OakmontBBQSelection { get; set; }

        [StringLength(200)]
        public string ChopShopSelection { get; set; }

        [StringLength(200)]
        public string DietaryRestrictions { get; set; }

        [StringLength(200)]
        public string SongRequest { get; set; }

        internal void Map(GuestResponseInfo responseInfo)
        {
            Attending = responseInfo.Attending;
            OakmontBBQSelection = responseInfo.OakmontBBQSelection;
            ChopShopSelection = responseInfo.ChopShopSelection;
            DietaryRestrictions = responseInfo.DietaryRestrictions;
            SongRequest = responseInfo.SongRequest;
        }
    }
}
