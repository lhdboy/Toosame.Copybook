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

namespace Toosame.Copybook.Core
{
    public class KouWordGridGenerate : IWordGridGenerate
    {
        protected const PenLineCap LinePenLineCap = PenLineCap.Triangle;
        protected const PenLineCap BorderPenLineCap = PenLineCap.Flat;

        protected const double LineStrokeThickness = 0.5;
        protected const double EdgeStrokeThickness = 1;
        protected const double BorderStrokeThickness = 4;

        protected readonly SolidColorBrush LineColor = new SolidColorBrush(Color.FromArgb(255, 165, 191, 221));
        protected readonly SolidColorBrush EdgeColor = new SolidColorBrush(Color.FromArgb(255, 139, 180, 228));
        protected readonly SolidColorBrush BorderColor = new SolidColorBrush(Color.FromArgb(255, 156, 174, 197));

        /// <summary>
        /// 标准内部格子
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas Generate(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "标准格子";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            return canvas;
        }

        /// <summary>
        /// 底部
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateBottomEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "底部";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            return canvas;
        }

        /// <summary>
        /// 左下角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateLeftBottomEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Line leftLine = new Line()
            {
                Y2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "左下角";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            canvas.Children.Add(leftLine);
            return canvas;
        }

        /// <summary>
        /// 左边
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateLeftEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line leftLine = new Line()
            {
                Y2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "左边";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            //顶部边框
            canvas.Children.Add(leftLine);

            return canvas;
        }

        /// <summary>
        /// 左上角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateLeftTopEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line leftLine = new Line()
            {
                Y2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Line topLine = new Line()
            {
                X2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "左上角";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            canvas.Children.Add(leftLine);
            canvas.Children.Add(topLine);
            return canvas;
        }

        /// <summary>
        /// 右下角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateRightBottomEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "右下角";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            return canvas;
        }

        /// <summary>
        /// 右边
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateRightEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "右边";

            //内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            return canvas;
        }

        /// <summary>
        /// 右上角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateRightTopEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line topLine = new Line()
            {
                X2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "右上角";

            //米字内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);
            canvas.Children.Add(topLine);

            return canvas;
        }

        /// <summary>
        /// 顶部
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public Canvas GenerateTopEdge(double area)
        {
            Line rightLine = new Line()
            {
                Y1 = area,
                X2 = area,
                X1 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line bottomLine = new Line()
            {
                X2 = area,
                Y1 = area,
                Y2 = area,
                Stroke = EdgeColor,
                StrokeEndLineCap = LinePenLineCap,
                StrokeThickness = EdgeStrokeThickness,
            };

            Line topLine = new Line()
            {
                X2 = area,
                Stroke = BorderColor,
                StrokeEndLineCap = BorderPenLineCap,
                StrokeThickness = BorderStrokeThickness,
            };

            Canvas canvas = new Canvas();
            canvas.Tag = "顶部";

            //米字内部线条
            Array.ForEach(GetGrid(area), p => canvas.Children.Add(p));

            //右下两边线条
            canvas.Children.Add(rightLine);
            canvas.Children.Add(bottomLine);

            //顶部边框
            canvas.Children.Add(topLine);

            return canvas;
        }

        protected virtual UIElement[] GetGrid(double area) => new Line[] { };
    }
}
