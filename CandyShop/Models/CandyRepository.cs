using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        //Bring the category repository and select the category for the candy
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy { CandyId=1, Name="Assorted hard Candy", Price=4.95M,Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                        Category = _categoryRepository.GetAllCategories.ToList()[0], IsInStock=true, IsOnSale=false, ImageUrl="https://pixabay.com/photos/caramel-candy-sweetmeats-sweet-1952997/", ImageThumbnailUrl="https://pixabay.com/photos/candy-sweetmeats-sweets-dessert-1961536/"},
            new Candy { CandyId=2, Name="Chocolate  Candy", Price=3.95M,Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book. It usually begins with:",
                        Category = _categoryRepository.GetAllCategories.ToList()[1], IsInStock=true, IsOnSale=false, ImageUrl="https://pixabay.com/photos/chocolate-dark-coffee-confiserie-183543/", ImageThumbnailUrl="https://pixabay.com/photos/chocolate-dark-coffee-confiserie-183543/"},
            new Candy { CandyId=3, Name="Assorted Jam", Price=5.95M,Description="The passage experienced a surge in popularity during the 1960s when Letraset used it on their dry-transfer sheets, and again during the 90s as desktop publishers bundled the text with their software. Today it's seen all around the web; on templates, websites, and stock designs.",
                        Category = _categoryRepository.GetAllCategories.ToList()[2], IsInStock=true, IsOnSale=true, ImageUrl="https://pixabay.com/photos/sugar-sweet-jelly-fruit-colorful-3485430/", ImageThumbnailUrl="https://pixabay.com/photos/sugar-sweet-jelly-fruit-colorful-3485430/"}
        };
        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
