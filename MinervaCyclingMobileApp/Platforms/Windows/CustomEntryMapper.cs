using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using MinervaCyclingMobileApp.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows;
using Colors = Microsoft.UI.Colors;

namespace MinervaCyclingMobileApp.Platforms
{
    public static class CustomEntryMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            if (view is CustomEntry)
            {
                var casted = (EntryHandler)handler;
                var viewData = (CustomEntry)view;

                if (handler.MauiContext.Services.GetService(typeof(Microsoft.UI.Xaml.Controls.Canvas)) is Microsoft.UI.Xaml.Controls.Canvas)
                {
                    var border = new Microsoft.UI.Xaml.Controls.Border
                    {
                        BorderThickness = new Microsoft.UI.Xaml.Thickness(viewData.BorderThickness),
                        BorderBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(viewData.BorderColor.ToWindowsColor()),
                        Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(viewData.BackgroundColor.ToWindowsColor()),
                        CornerRadius = new Microsoft.UI.Xaml.CornerRadius(viewData.CornerRadius)

                    };
                    casted.PlatformView.Background = border.Background;
                    casted.PlatformView.BorderBrush = border.BorderBrush;
                    casted.PlatformView.BorderThickness = border.BorderThickness;
                    casted.PlatformView.CornerRadius = border.CornerRadius;
                }

                
                
            }
        }
    }
}
