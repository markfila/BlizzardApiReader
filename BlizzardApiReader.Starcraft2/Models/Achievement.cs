using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AchievementId { get; set; }
        public int CategoryId { get; set; }
        public int Points { get; set; }
        public Icon Icon { get; set; }
        public List<Category> Categories { get; set; }
    }

    public class Icon
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public int Offset { get; set; }
        public string Url { get; set; }
    }

    public class Category
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int FeaturedAchievementId { get; set; }
        public List<Category> Children { get; set; }
    }

    
}
