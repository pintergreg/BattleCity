using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Avalonia.Markup;
using Avalonia.Media.Imaging;
using BattleCity.Models;
using Avalonia.Data.Converters;


namespace BattleCity.Infrastructure
{
    public class TerrainTileConverter : IValueConverter
    {
        public static TerrainTileConverter Instance { get; } = new TerrainTileConverter();
        private static Dictionary<TerrainTileType, Bitmap> _cache;

        Dictionary<TerrainTileType, Bitmap> GetCache()
        {

            return
                _cache ??
                (_cache = Enum.GetValues(typeof(TerrainTileType)).OfType<TerrainTileType>().ToDictionary(t => t, t =>
                    new Bitmap(
                        typeof(TerrainTileConverter).GetTypeInfo()
                            .Assembly.GetManifestResourceStream($"BattleCity.Assets.{t}.png"))));
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => GetCache()[(TerrainTileType) value];

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
