using Microsoft.EntityFrameworkCore;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                //context.Database.EnsureCreated();

                var user1 = new User { UserName = "User1", Settings = new UserSettings { Theme = "Light", Language = "English" } };
                var user2 = new User { UserName = "User2", Settings = new UserSettings { Theme = "Dark", Language = "Russian" } };

                context.Users.AddRange(user1, user2);
                context.SaveChanges();

                var retrievedUser = context.Users.Include(u => u.Settings).SingleOrDefault(u => u.Id == 2);

                if (retrievedUser != null)
                {
                    Console.WriteLine($"User: {retrievedUser.UserName}, Theme: {retrievedUser.Settings?.Theme}, Language: {retrievedUser.Settings?.Language}");
                }

                var userToDelete = context.Users.SingleOrDefault(u => u.Id == 3);

                if (userToDelete != null)
                {
                    context.Users.Remove(userToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}