using MinervaCyclingMobileApp.Interfaces;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Services
{
    public class SelectedImageService : ISelectedImageService
    {
        public async Task<ImageSource> UploadPhoto()
        {
            // Check the permissions for accessing photos.
            PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.Photos>();

            if (status == PermissionStatus.Denied || status == PermissionStatus.Unknown || status == PermissionStatus.Disabled)
            {
                // If permission is not granted, request it.
                status = await Permissions.RequestAsync<Permissions.Photos>();

                if (status == PermissionStatus.Denied || status == PermissionStatus.Unknown || status == PermissionStatus.Disabled)
                {
                    await App.Current.MainPage.DisplayAlert("Required", "You must allow the permission to get your image", "Ok");
                    return null; // If still not granted, display an alert and return.
                }
            }

            // Here, you have permission. Use FilePicker to pick an image.
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select image(s) to send",
                FileTypes = FilePickerFileType.Images
            });

            if (result == null)
                return null; // If user didn't pick an image, return.

            using (var stream = await result.OpenReadAsync())
            {
                // Convert the stream to an MAUI image.
                var image = Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(stream);

                // If the image is too large, resize it.
                int maxImageSize = 1600;
                if (image.Width > maxImageSize || image.Height > maxImageSize)
                {
                    image = image.Downsize(maxImageSize, true);
                }

                // Convert the resized image to bytes with PNG format.
                byte[] bytes = await image.AsBytesAsync(ImageFormat.Png);

                // Convert the bytes to a Base64 string.
                string uploadImage = $"data:image/png;base64,{Convert.ToBase64String(bytes)}";

                return uploadImage; // Return the Base64 string.
            }
        }


        public async Task<ImageSource> CapturePhoto()
        {
            // Check camera permission status
            PermissionStatus cameraStatus = await Permissions.CheckStatusAsync<Permissions.Camera>();

            if (cameraStatus != PermissionStatus.Granted)
            {
                cameraStatus = await Permissions.RequestAsync<Permissions.Camera>();
                if (cameraStatus != PermissionStatus.Granted)
                {
                    await App.Current.MainPage.DisplayAlert("Required", "Camera permission is needed to capture photos.", "Ok");
                    return null;
                }
            }

            // Use MediaPicker to capture photo
            var photoResult = await MediaPicker.CapturePhotoAsync();

            if (photoResult == null)
                return null;

            Microsoft.Maui.Graphics.IImage capturedImage;

            using (var stream = await photoResult.OpenReadAsync())
            {
                    
                SKBitmap photoBitmap = RotateBitmap(SKBitmap.Decode(stream));
                Stream rotatedStream = SKImage.FromBitmap(photoBitmap).Encode().AsStream();

                capturedImage = Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(rotatedStream);
            }

            int maxImageSize = 1600;
            float precision = 0.8f;
            byte[] bytes;

            if (capturedImage.Width > maxImageSize || capturedImage.Height > maxImageSize)
            {
                capturedImage = capturedImage.Downsize(maxImageSize, true);
            }
            bytes = await capturedImage.AsBytesAsync(ImageFormat.Png, precision);

            return ImageSource.FromStream(() => new MemoryStream(bytes));

        }

        SKBitmap RotateBitmap(SKBitmap bitmap)
        {
            SKBitmap rotatedBitmap = new SKBitmap(bitmap.Height, bitmap.Width);
            using (var surface = new SKCanvas(rotatedBitmap))
            {
                surface.Translate(rotatedBitmap.Width, 0);
                surface.RotateDegrees(35);
                surface.DrawBitmap(bitmap, 0, 0);
            }
            return rotatedBitmap;
        }
    }
}
