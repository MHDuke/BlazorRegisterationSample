using System.Collections.Generic;

namespace UI.RegisterationModel
{
    public class Category
    {
        //"Fitness club", "hair dresser", "spa"
        public int Id { get; set; }
        public string Name { get; set; }
        public static IEnumerable<Category> Categories => new[]
        {
            new Category { Id=1, Name = "Fitness club" },
            new Category { Id = 2, Name = "hair dresser"},
            new Category { Id=3, Name =  "spa"}
        };
    }
}
