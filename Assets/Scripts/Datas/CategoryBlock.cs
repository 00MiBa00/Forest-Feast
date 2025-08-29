using System.Collections.Generic;
using Types;

namespace Datas
{
    public class CategoryBlock
    {
        public RecipeType Category;
        public List<RecipeData> Recipes = new();
    }
}