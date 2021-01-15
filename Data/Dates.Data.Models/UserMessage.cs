namespace Dates.Data.Models
{
    using System;

    using Dates.Data.Common.Models;

    public class UserMessage : BaseDeletableModel<string>
    {
        public UserMessage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Message { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
