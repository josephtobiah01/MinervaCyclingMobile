﻿using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using MinervaCyclingMobile.CustomControls;
using Windows.Graphics.Display;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobile.Platforms
{
    public class CustomEntryMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            //if (view is CustomEntry)
            //{
            //    var casted = (EntryHandler)handler;
            //    var viewData = (CustomEntry)view;

            //    var gd = new GradientDrawable();

            //    gd.SetCornerRadius((int)handler.MauiContext?.Context.ToPixels(viewData.CornerRadius));

            //    gd.SetStroke((int)handler.MauiContext?.Context.ToPixels(viewData.BorderThickness), viewData.BorderColor.ToAndroid());

            //    if (viewData.BackgroundColor != null)
            //    {
            //        gd.SetColor(viewData.BackgroundColor.ToAndroid());
            //    }


            //    casted.PlatformView?.SetBackground(gd);

            //    int paddingPixel = (int)handler.MauiContext?.Context.ToPixels(10); // Example
            //    casted.PlatformView?.SetPadding(paddingPixel, paddingPixel, paddingPixel, paddingPixel);
            //}

            throw new NotImplementedException(nameof(handler));
        }
    }
}