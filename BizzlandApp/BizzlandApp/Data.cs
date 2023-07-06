using BizzlandApp.Models;

namespace BizzlandApp
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>
        {
            new Service{Id=1,Title = "Programming",Icon="bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=2,Title = "Design",Icon="bx bx-file",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=3,Title = "System",Icon="bx bx-tachometer",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=4,Title = "Digital Marketing",Icon="bx bx-world",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=4,Title = "Helpdesk",Icon="bx bx-world",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
        };

        public static List<TeamMember> TeamMembers = new List<TeamMember>
        {
            new TeamMember{Id=1,Position="CEO", FullName="Hikmet Abbasov",ImageName ="team-2.jpg",FbUrl = "http://facebook.com",InstagramUrl="http://facebook.com",LinkedinUrl="http://facebook.com",TwitterUrl="http://facebook.com"},
            new TeamMember{Id=2,Position="Asbaz", FullName="Tofiq Abbasov",ImageName ="team-1.jpg",FbUrl = "http://facebook.com",InstagramUrl="http://facebook.com",LinkedinUrl="http://facebook.com",TwitterUrl="http://facebook.com"},
            new TeamMember{Id=3,Position="Developer", FullName="Nermin Abbasova",ImageName ="team-4.jpg",FbUrl = "http://facebook.com",InstagramUrl="http://facebook.com",LinkedinUrl="http://facebook.com",TwitterUrl="http://facebook.com"},
            new TeamMember{Id=4,Position="Parkovsik", FullName="Nigar Abbaszade",ImageName ="team-3.jpg",FbUrl = "http://facebook.com",InstagramUrl="http://facebook.com",LinkedinUrl="http://facebook.com",TwitterUrl="http://facebook.com"},
        };
    }
}
