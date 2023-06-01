using System.Collections.Generic;

namespace soatveonline.ViewModel
{
    public class programsVM_Input
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int image { get; set; }
        public int time { get; set; }
        public double Pricstart_date { get; set; }
        public double end_start { get; set; }
      
    }

    public class programsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }

    public class programsVM_Details
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int image { get; set; }
        public int time { get; set; }
        public double Pricstart_date { get; set; }
        public double end_start { get; set; }
      
        public List<ShowVM> ListShow { get; set; }
    }
}
