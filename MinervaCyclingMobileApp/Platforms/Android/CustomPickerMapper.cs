using Android.Content;
using Android.Widget;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Service.Controls;

using AndroidX.Core.Content;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using MinervaCyclingMobileApp.CustomControls;
using System.Runtime.CompilerServices;
using Android.Util;

namespace MinervaCyclingMobileApp.Platforms.Android
{
    public class CustomPickerMapper : PickerHandler
    {
        public CustomPickerMapper() : base(new PropertyMapper<CustomPicker>())
        {
        }

        
        public static void Map(IElementHandler handler, IElement view)
        {
            if (view is CustomPicker)
            {
                var casted = (PickerHandler)handler;

                var viewData = (CustomPicker)view;

                var gd = new GradientDrawable();
                
                BitmapDrawable RightImage = !string.IsNullOrEmpty(viewData.RightImage) ? GetDrawableRight(viewData.RightImage, handler.MauiContext?.Context) : null;
                BitmapDrawable LeftImage = !string.IsNullOrEmpty(viewData.LeftImage) ? GetDrawableLeft(viewData.LeftImage, handler.MauiContext?.Context) : null;

                if (handler.PlatformView is EditText editText)
                {
                    editText.Text = viewData.Title;
                    editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(LeftImage, null, RightImage, null);
                    editText.CompoundDrawablePadding = 10;

                    if (RightImage != null)
                    {
                        RightImage.SetBounds(0, 0, (int)DpToPixels(handler.MauiContext?.Context, viewData.RightImageWidth),
                            (int)DpToPixels(handler.MauiContext?.Context, viewData.RightImageHeight));
                    }

                }

                gd.SetCornerRadius((int)handler.MauiContext?.Context.ToPixels(viewData.CornerRadius));

                gd.SetStroke((int)handler.MauiContext?.Context.ToPixels(viewData.BorderThickness), viewData.BorderColor.ToAndroid());

                gd.SetColor(viewData.BackgroundColor.ToAndroid());


                casted.PlatformView?.SetBackground(gd);


                casted.PlatformView?.SetPadding(
                    (int)DpToPixels(handler.MauiContext.Context, Convert.ToSingle(7)), casted.PlatformView.PaddingTop,
                    (int)DpToPixels(handler.MauiContext.Context, Convert.ToSingle(7)), casted.PlatformView.PaddingBottom);

                //int paddingPixel = (int)handler.MauiContext?.Context.ToPixels(7); // Example
                //casted.PlatformView?.SetPadding(paddingPixel, paddingPixel, paddingPixel, paddingPixel);



            }

        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }


        public static BitmapDrawable GetDrawableRight(string imageEntryImage, Context context)
        {
            //Context context = null;
            int resID = context.Resources.GetIdentifier(imageEntryImage, "drawable", context.PackageName);
            if (resID == 0)
            {
                // The resource was not found
                return null;
            }
            Drawable drawable = ContextCompat.GetDrawable(context, resID);
            Bitmap bitmap = ((BitmapDrawable)drawable).Bitmap;

            return new BitmapDrawable(context.Resources, bitmap);
        }

        public static BitmapDrawable GetDrawableLeft(string imageEntryImage, Context context)
        {
            //Context context = null;
            int resID = context.Resources.GetIdentifier(imageEntryImage, "drawable", context.PackageName);
            if (resID == 0)
            {
                // The resource was not found
                return null;
            }
            Drawable drawable = ContextCompat.GetDrawable(context, resID);
            Bitmap bitmap = ((BitmapDrawable)drawable).Bitmap;

            return new BitmapDrawable(context.Resources, bitmap);
        }


    }
}
