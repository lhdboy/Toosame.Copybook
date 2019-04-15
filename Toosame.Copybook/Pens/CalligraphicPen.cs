using Windows.Foundation;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Toosame.Copybook.Pens
{
    public class CalligraphicPen : InkToolbarCustomPen
    {
        protected override InkDrawingAttributes CreateInkDrawingAttributesCore(Brush brush, double strokeWidth)
        {
            SolidColorBrush solidColorBrush = (SolidColorBrush)brush;

            InkDrawingAttributes inkDrawingAttributes = new InkDrawingAttributes
            {

                PenTip = PenTipShape.Circle,
                IgnorePressure = false,
                Size = new Size(strokeWidth, 2.0f * strokeWidth),
                PenTipTransform = System.Numerics.Matrix3x2.CreateRotation(45.0f)
            };

            if (solidColorBrush != null)
                inkDrawingAttributes.Color = solidColorBrush.Color;

            return inkDrawingAttributes;
        }
    }
}
