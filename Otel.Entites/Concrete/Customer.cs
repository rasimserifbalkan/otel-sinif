using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Otel.Core.Entities;//--------------

namespace Otel.Entites.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Image CustomerPicture { get; set; }
    }
}
