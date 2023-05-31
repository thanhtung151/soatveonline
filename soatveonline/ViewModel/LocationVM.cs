using System.ComponentModel.DataAnnotations;

namespace HueFestival_OnlineTicket.ViewModel
{
    public class LocationVM
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string summary { get; set; }
       
        public string image { get; set; }
    }

    public class LocationVM_Input
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string summary { get; set; }

       

        [Required]
        public string image { get; set; }

        

       
    }

    public class LocationVM_Details
    {
        public int Id { get; set; }

        public string name { get; set; }
        public string summary { get; set; }
        

        public string image { get; set; }
       
    }
}
