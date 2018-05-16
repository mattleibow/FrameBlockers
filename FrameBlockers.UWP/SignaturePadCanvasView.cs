using FrameBlockers;
using FrameBlockers.UWP;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SignaturePadCanvasView), typeof(SignaturePadCanvasRenderer))]

namespace FrameBlockers.UWP
{
    public class NativeSignaturePadCanvasView : UserControl
    {
        public NativeSignaturePadCanvasView()
        {
            HorizontalContentAlignment = HorizontalAlignment.Stretch;
            VerticalContentAlignment = VerticalAlignment.Stretch;

            var inkCanvas = new InkCanvas
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
            };

            inkCanvas.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Touch | CoreInputDeviceTypes.Pen | CoreInputDeviceTypes.Mouse;

            Content = inkCanvas;
        }
    }

    public class SignaturePadCanvasRenderer : ViewRenderer<SignaturePadCanvasView, NativeSignaturePadCanvasView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SignaturePadCanvasView> e)
        {
            base.OnElementChanged(e);

            var native = new NativeSignaturePadCanvasView
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            SetNativeControl(native);
        }
    }
}
