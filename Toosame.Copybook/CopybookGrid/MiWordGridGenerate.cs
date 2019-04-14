using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Toosame.Copybook.CopybookGrid
{
    public class MiWordGridGenerate : TianWordGridGenerate
    {
        //private const PenLineCap LinePenLineCap = PenLineCap.Triangle;
        //private const PenLineCap BorderPenLineCap = PenLineCap.Flat;

        //private const double LineStrokeThickness = 0.5;
        //private const double EdgeStrokeThickness = 1;
        //private const double BorderStrokeThickness = 4;

        //private readonly SolidColorBrush _lineColor = new SolidColorBrush(Color.FromArgb(255, 165, 191, 221));
        //private readonly SolidColorBrush _edgeColor = new SolidColorBrush(Color.FromArgb(255, 139, 180, 228));
        //private readonly SolidColorBrush _borderColor = new SolidColorBrush(Color.FromArgb(255, 156, 174, 197));

        ///// <summary>
        ///// 标准内部格子
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas Generate(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "标准格子";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    return canvas;
        //}

        ///// <summary>
        ///// 底部
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateBottomEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "底部";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    return canvas;
        //}

        ///// <summary>
        ///// 左下角
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateLeftBottomEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Line leftLine = new Line()
        //    {
        //        Y2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "左下角";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    canvas.Children.Add(leftLine);
        //    return canvas;
        //}

        ///// <summary>
        ///// 左边
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateLeftEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line leftLine = new Line()
        //    {
        //        Y2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "左边";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    //顶部边框
        //    canvas.Children.Add(leftLine);

        //    return canvas;
        //}

        ///// <summary>
        ///// 左上角
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateLeftTopEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line leftLine = new Line()
        //    {
        //        Y2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Line topLine = new Line()
        //    {
        //        X2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "左上角";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    canvas.Children.Add(leftLine);
        //    canvas.Children.Add(topLine);
        //    return canvas;
        //}

        ///// <summary>
        ///// 右下角
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateRightBottomEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "右下角";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    return canvas;
        //}

        ///// <summary>
        ///// 右边
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateRightEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "右边";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    return canvas;
        //}

        ///// <summary>
        ///// 右上角
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateRightTopEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line topLine = new Line()
        //    {
        //        X2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "右上角";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);
        //    canvas.Children.Add(topLine);

        //    return canvas;
        //}

        ///// <summary>
        ///// 顶部
        ///// </summary>
        ///// <param name="area"></param>
        ///// <returns></returns>
        //public Canvas GenerateTopEdge(double area)
        //{
        //    Line rightLine = new Line()
        //    {
        //        Y1 = area,
        //        X2 = area,
        //        X1 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line bottomLine = new Line()
        //    {
        //        X2 = area,
        //        Y1 = area,
        //        Y2 = area,
        //        Stroke = _edgeColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = EdgeStrokeThickness,
        //    };

        //    Line topLine = new Line()
        //    {
        //        X2 = area,
        //        Stroke = _borderColor,
        //        StrokeEndLineCap = BorderPenLineCap,
        //        StrokeThickness = BorderStrokeThickness,
        //    };

        //    Canvas canvas = new Canvas();
        //    canvas.Tag = "顶部";

        //    //米字内部线条
        //    canvas.Children.Add(GetLine1(area));
        //    canvas.Children.Add(GetLine2(area));
        //    canvas.Children.Add(GetLine3(area));
        //    canvas.Children.Add(GetLine4(area));

        //    //右下两边线条
        //    canvas.Children.Add(rightLine);
        //    canvas.Children.Add(bottomLine);

        //    //顶部边框
        //    canvas.Children.Add(topLine);

        //    return canvas;
        //}

        protected override UIElement[] GetGrid(double area)
            => new Line[] { GetLine1(area), GetLine2(area), GetLine3(area), GetLine4(area) };

        /// <summary>
        /// \
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        private Line GetLine1(double area)
            => new Line()
            {
                X2 = area,
                Y2 = area,
                Stroke = LineColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = LineStrokeThickness,
            };

        /// <summary>
        /// /
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        private Line GetLine2(double area)
            => new Line()
            {
                Y1 = area,
                X2 = area,
                Stroke = LineColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = LineStrokeThickness,
            };

        //private Line GetLine3(double area)
        //    => new Line()
        //    {
        //        X2 = area,
        //        Y1 = area / 2,
        //        Y2 = area / 2,
        //        Stroke = _lineColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = LineStrokeThickness,
        //    };

        //private Line GetLine4(double area)
        //    => new Line()
        //    {
        //        X1 = area / 2,
        //        Y1 = area,
        //        X2 = area / 2,
        //        Stroke = _lineColor,
        //        StrokeEndLineCap = LinePenLineCap,
        //        StrokeThickness = LineStrokeThickness,
        //    };
    }
}
