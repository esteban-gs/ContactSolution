using System;
using System.Collections.Generic;
using System.Text;

namespace ContactRepository.Maps
{
    public class ContactForCreationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
