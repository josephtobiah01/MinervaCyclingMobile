using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Platforms
{
    public class CustomPickerMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            //if (view is CustomEntry)
            //{
            //    var casted = (EntryHandler)handler;
            //    var viewData = (CustomEntry)view;

            //    UpdateBackground(casted.PlatformView, viewData);

            //    var paddingViewLeft = new UIView(new CGRect(0, 0, 10, 0)); // Hardcoded for now
            //    casted.PlatformView.LeftView = paddingViewLeft;
            //    casted.PlatformView.LeftViewMode = UITextFieldViewMode.Always;

            //    var paddingViewRight = new UIView(new CGRect(0, 0, 10, 0)); // Hardcoded for now
            //    casted.PlatformView.RightView = paddingViewRight;
            //    casted.PlatformView.RightViewMode = UITextFieldViewMode.Always;
            //}
            throw new ArgumentNullException(nameof(handler));
        }

        //private static void UpdateBackground(UITextField control, CustomEntry entry)
        //{
        //    if (control == null) return;

        //    control.Layer.CornerRadius = entry.CornerRadius;
        //    control.Layer.BorderWidth = entry.BorderThickness;
        //    control.Layer.BorderColor = entry.BorderColor.ToCGColor();
        //    control.BorderStyle = UITextBorderStyle.Line;
        //}
    }
}
