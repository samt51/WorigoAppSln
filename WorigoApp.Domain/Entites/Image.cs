using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Image : EntityBase
    {
        public Image()
        {

        }
        public string ImageUrl { get; set; }
        public int ImageCategoryId { get; set; }
        public ImageCategory ImageCategory { get; set; }
        public int? OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        public int? FoodId { get; set; }
        public Food Food { get; set; }
        public Image(string imageUrl, int imageCategoryId)
        {
            this.ImageUrl = imageUrl;
            this.ImageCategoryId = imageCategoryId;
        }
    }
}
