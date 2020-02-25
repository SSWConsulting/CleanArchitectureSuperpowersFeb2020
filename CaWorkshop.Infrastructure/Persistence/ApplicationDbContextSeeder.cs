using CaWorkshop.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CaWorkshop.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.TodoLists.Any())
            {
                return;
            }

            context.TodoLists.Add(
                new TodoList
                {
                    Title = "Death List Five",
                    Items = new List<TodoItem>
                    {
                        new TodoItem
                        {
                            Title = "O-Ren Ishii",
                            Done = true
                        },
                        new TodoItem
                        {
                            Title = "Vernita Green",
                            Done = true
                        },
                        new TodoItem
                        {
                            Title = "Budd",
                            Done = true
                        },
                        new TodoItem
                        {
                            Title = "Ellie Driver"
                        },
                        new TodoItem
                        {
                            Title = "Bill"
                        }
                    }
                }
            );

            context.SaveChanges();
        }
    }
}