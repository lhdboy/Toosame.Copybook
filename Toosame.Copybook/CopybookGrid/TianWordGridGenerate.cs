using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Shapes;

namespace Toosame.Copybook.CopybookGrid
{

    public class TianWordGridGenerate : KouWordGridGenerate
    {
        protected override UIElement[] GetGrid(double area)
            => new Line[] { GetLine3(area), GetLine4(area) };

        /// <summary>
        /// ——
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        protected virtual Line GetLine3(double area)
            => new Line()
            {
                X2 = area,
                Y1 = area / 2,
                Y2 = area / 2,
                Stroke = LineColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = LineStrokeThickness,
            };

        /// <summary>
        /// |
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        protected virtual Line GetLine4(double area)
            => new Line()
            {
                X1 = area / 2,
                Y1 = area,
                X2 = area / 2,
                Stroke = LineColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = LineStrokeThickness,
            };
    }
}
