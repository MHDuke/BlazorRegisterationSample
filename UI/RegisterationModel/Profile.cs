using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.RegisterationModel
{
    public class Profile
    {
        public string BusinessName { get; set; }
        public string OwnerName { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
