using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class FeedBackAndSurveyConfiguration : IEntityTypeConfiguration<FeedBackAndSurvey>
    {
        public void Configure(EntityTypeBuilder<FeedBackAndSurvey> builder)
        {
           
        }
    }
}
