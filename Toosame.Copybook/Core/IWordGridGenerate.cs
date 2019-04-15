using Windows.UI.Xaml.Controls;

namespace Toosame.Copybook.Core
{
    public interface IWordGridGenerate
    {
        /// <summary>
        /// 生成一个标准格子
        /// </summary>
        /// <param name="area">面积</param>
        /// <returns></returns>
        Canvas Generate(double area);

        /// <summary>
        /// 生成顶部边缘的格子
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateTopEdge(double area);

        /// <summary>
        /// 生成低部边缘的格子
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateBottomEdge(double area);

        /// <summary>
        /// 生成右边边缘的格子
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateRightEdge(double area);

        /// <summary>
        /// 生成左边边缘的格子
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateLeftEdge(double area);

        /// <summary>
        /// 左上角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateLeftTopEdge(double area);

        /// <summary>
        /// 左下角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateLeftBottomEdge(double area);

        /// <summary>
        /// 右上角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateRightTopEdge(double area);

        /// <summary>
        /// 右下角
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        Canvas GenerateRightBottomEdge(double area);
    }
}
