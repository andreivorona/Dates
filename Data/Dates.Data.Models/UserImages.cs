namespace Dates.Data.Models
{
    using System;

    using Dates.Data.Common.Models;

    public class UserImages : BaseDeletableModel<string>
    {
        public UserImages()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
