using UnityEngine;

namespace ViewModels
{
    public class DishPreview
    {
        public string Title { get; private set; }
        public Sprite Icon { get; private set; }

        public DishPreview(string title, UnityEngine.Sprite icon)
        {
            Title = title;
            Icon = icon;
        }
    }
}