namespace LeagueAppManagement.Migrations
{
    using LeagueAppManagement.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext dbcontext)
        {

            //var player = new Player
            //{
            //    FirstName = "Emmanuel",
            //    LastName = "Genest",
            //    PhoneNumber = "819-850-5000",
            //    Grade = GradeEnum.C
            //};

            //dbcontext.Players.Add(player);

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(dbcontext));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(dbcontext));
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool   
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser
                {
                    UserName = "emmanbern",
                    Email = "emmanbern@gmail.com"
                };

                string userPWD = "joueur_69";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new IdentityRole
                {
                    Name = "Manager"
                };
                roleManager.Create(role);

            }

            // creating Creating Employee role    
            if (!roleManager.RoleExists("Player"))
            {
                var role = new IdentityRole
                {
                    Name = "Player"
                };
                roleManager.Create(role);

            }

            dbcontext.SaveChanges();
        }
    }
}
