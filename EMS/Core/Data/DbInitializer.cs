using EMS.Core.Models;

namespace EMS.Core.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                var user = new User
                {
                    userName = "user",
                    password = "password",
                    role = "Admin"
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}