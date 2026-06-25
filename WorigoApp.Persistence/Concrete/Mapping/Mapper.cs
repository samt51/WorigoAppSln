using AutoMapper;
using AutoMapper.Internal;

namespace WorigoApp.Persistence.Concrete.Mapping
{
    /// <summary>
    /// Mapper sınıfını temsil eder.
    /// </summary>
    public class Mapper : Application.Interfaces.AutoMapper.IMapper
    {
/// <summary>
/// typePairs değerini alır veya ayarlar.
/// </summary>
public static List<TypePair> typePairs = new();
        private AutoMapper.IMapper MapperContainer;
/// <summary>
/// Mapper sınıfının yeni bir örneğini başlatır.
/// </summary>
public Mapper()
        {
            InitializeMapper();
        }
/// <summary>
/// Map işlemini gerçekleştirir.
/// </summary>
public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);

            return MapperContainer.Map<TSource, TDestination>(source);
        }
/// <summary>
/// Map işlemini gerçekleştirir.
/// </summary>
public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);

            return MapperContainer.Map<IList<TSource>, IList<TDestination>>(source);
        }
/// <summary>
/// Map işlemini gerçekleştirir.
/// </summary>
public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination, object>(5, ignore);

            return MapperContainer.Map<TDestination>(source);
        }
/// <summary>
/// Map işlemini gerçekleştirir.
/// </summary>
public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
        {
            Config<TDestination, IList<object>>(5, ignore);

            return MapperContainer.Map<IList<TDestination>>(source);
        }

        private void InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                foreach (var typePair in typePairs)
                {
                    CreateMapWithIgnore(cfg, typePair.SourceType, typePair.DestinationType);
                }

                cfg.AddProfile<MappingProfile>(); // Profilinizi burada yükleyin
            });
            MapperContainer = config.CreateMapper();
        }
        private void CreateMapWithIgnore(IMapperConfigurationExpression cfg, Type sourceType, Type destinationType, string? ignore = null)
        {
            if (ignore != null)
            {
                cfg.CreateMap(sourceType, destinationType).ForMember(ignore, opt => opt.Ignore()).ReverseMap();
            }
            else
            {
                cfg.CreateMap(sourceType, destinationType).ReverseMap();
            }
        }
/// <summary>
/// Config işlemini gerçekleştirir.
/// </summary>
protected void Config<TDestionation, TSource>(int depth = 5, string? ignore = null)
        {

            var typePair = new TypePair(typeof(TSource), typeof(TDestionation));
            if (!typePairs.Any(a => a.SourceType == typePair.SourceType && a.DestinationType == typePair.DestinationType))
            {
                typePairs.Add(typePair);
                var config = new MapperConfiguration(cfg =>
                {
                    CreateMapWithIgnore(cfg, typeof(TSource), typeof(TDestionation), ignore);

                    cfg.AddProfile<MappingProfile>(); // Profilinizi burada yükleyin
                });
                MapperContainer = config.CreateMapper();
            }
        }
    }
}
