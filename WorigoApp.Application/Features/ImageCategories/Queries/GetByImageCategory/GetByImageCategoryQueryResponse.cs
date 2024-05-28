﻿using WorigoApp.Application.Features.Hotels.Queries.GetAllHotels;
using WorigoApp.Application.Features.Images.Queries.GetImages;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetByImageCategory
{
    public class GetByImageCategoryQueryResponse
    {
        public string Name { get; set; }
        public int HotelId { get; set; }
        public GetAllHotelsQueryResponse Hotel { get; set; }
        public IList<GetImagesQueryResponse> Images { get; set; }
    }
}
