using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MinervaCyclingMobileApp.CustomControls
{
    public class CustomPicker : Picker
    {
        public static BindableProperty BorderThicknessProperty =
            BindableProperty.Create(nameof(BorderThickness), typeof(int), typeof(CustomPicker), null);

        private static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CustomPicker), default(ICommand));

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomPicker), Colors.Transparent);

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(CustomPicker), null);

        public static readonly BindableProperty LeftImageProperty =
            BindableProperty.Create(nameof(LeftImage), typeof(string), typeof(CustomPicker), string.Empty);


        public static readonly BindableProperty RightImageProperty =
            BindableProperty.Create(nameof(RightImage), typeof(string), typeof(CustomPicker), string.Empty);


        public static readonly BindableProperty LeftImageHeightProperty =
            BindableProperty.Create(nameof(LeftImageHeight), typeof(int), typeof(CustomPicker), null);

        public static readonly BindableProperty LeftImageWidthProperty =
            BindableProperty.Create(nameof(LeftImageWidth), typeof(int), typeof(CustomPicker), null);


        public static readonly BindableProperty RightImageHeightProperty =
            BindableProperty.Create(nameof(RightImageHeight), typeof(int), typeof(CustomPicker), null);

        public static readonly BindableProperty RightImageWidthProperty =
            BindableProperty.Create(nameof(RightImageWidth), typeof(int), typeof(CustomPicker), null);

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }
        
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        
        
        public string LeftImage
        {
            get => (string)GetValue(LeftImageProperty);
            set => SetValue(LeftImageProperty, value);
        }
        
        public string RightImage
        {
            get => (string)GetValue(RightImageProperty);
            set => SetValue(RightImageProperty, value);
        }
        
        public int LeftImageWidth
        {
            get => (int)GetValue(LeftImageWidthProperty);
            set => SetValue(LeftImageWidthProperty, value);
        }
        
        public int LeftImageHeight
        {
            get => (int)GetValue(LeftImageHeightProperty);
            set => SetValue(LeftImageHeightProperty, value);
        }
        
        public int RightImageWidth
        {
            get => (int)GetValue(RightImageWidthProperty);
            set => SetValue(RightImageWidthProperty, value);
        }
        
        public int RightImageHeight
        {
            get => (int)GetValue(RightImageHeightProperty);
            set => SetValue(RightImageHeightProperty, value);
        }

        public int BorderThickness
        {
            get => (int)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        

        
    }
}
