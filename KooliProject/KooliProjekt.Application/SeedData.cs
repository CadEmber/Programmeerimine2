using KooliProjekt.Application.Data;
using KooliProjekt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace KooliProjekt.Application
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any users.
                if (context.Users.Any())
                {
                    return;   // Data was already seeded
                }

                // 1. Add Users
                var user1 = new User { UserName = "Gunnar", PasswordHash = "hash123" };
                var user2 = new User { UserName = "Admin", PasswordHash = "admin123" };
                context.Users.AddRange(user1, user2);
                context.SaveChanges();

                // 2. Add TodoLists linked to users
                var list1 = new TodoList { Title = "School Tasks", UserId = user1.Id };
                var list2 = new TodoList { Title = "Groceries", UserId = user2.Id };
                context.TodoLists.AddRange(list1, list2);
                context.SaveChanges();

                // 3. Add TodoItems
                context.TodoItems.AddRange(
                    new TodoItem { Title = "Finish EF Core setup", IsCompleted = true, TodoListId = list1.Id },
                    new TodoItem { Title = "Complete database seeding", IsCompleted = false, TodoListId = list1.Id },
                    new TodoItem { Title = "Buy milk", IsCompleted = false, TodoListId = list2.Id }
                );

                context.SaveChanges();
            }
        }
    }
}