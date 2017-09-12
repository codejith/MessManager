using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MessManager.Modals
{
    public class User
    {
        public int profileID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Designation { get; set; }

        public string Email { get; set; }

        public int ContactNumber { get; set; }

    }
}
