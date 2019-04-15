using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toosame.Copybook.Pens;
using Windows.UI;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Toosame.Copybook.Core
{
    public class CopybookControlBuilder
    {
        public Grid CopybookAresGrid { get; private set; }

        public bool IsGenerateWordGrid { get; private set; }

        private readonly List<Canvas> _canvasList;
        private readonly List<TextBlock> _textBlockList;

        private readonly int _rowNum;
        private readonly int _colNum;
        private readonly double _area;

        public CopybookControlBuilder(int rowNum, int colNum, double area)
        {
            _canvasList = new List<Canvas>();
            _textBlockList = new List<TextBlock>();

            _rowNum = rowNum;
            _colNum = colNum;
            _area = area;

            Grid copybookArea = new Grid();
            copybookArea.Name = "copybookArea";
            copybookArea.HorizontalAlignment = HorizontalAlignment.Center;
            copybookArea.VerticalAlignment = VerticalAlignment.Center;
            copybookArea.Width = _colNum * _area;
            copybookArea.Height = _rowNum * _area;
            copybookArea.Background = new SolidColorBrush(Colors.White);

            CopybookAresGrid = copybookArea;
        }

        public InkToolbar GenerateInkToolbar(InkCanvas inkCanvas, Action<object, RoutedEventArgs> onChangeGrid)
        {
            InkToolbar inkToolbar = new InkToolbar();
            inkToolbar.Name = "inkToolbar";
            inkToolbar.InitialControls = InkToolbarInitialControls.None;
            inkToolbar.TargetInkCanvas = inkCanvas;
            //书法笔
            inkToolbar.Children.Add(new InkToolbarCustomPenButton()
            {
                CustomPen = new CalligraphicPen(),
                SelectedBrushIndex = 0,
                MinStrokeWidth = 2,
                MaxStrokeWidth = 20,
                SelectedStrokeWidth = 3,
                IsChecked = true,
                ConfigurationContent = new InkToolbarPenConfigurationControl(),
                Content = new FontIcon()
                {
                    FontFamily = new FontFamily("Segoe MDL2 Assets"),
                    Glyph = "\uEDFB",
                    FontSize = 16,
                },
            });
            //球点笔
            inkToolbar.Children.Add(new InkToolbarBallpointPenButton());
            //橡皮擦
            inkToolbar.Children.Add(new InkToolbarStencilButton());
            //尺规
            inkToolbar.Children.Add(new InkToolbarEraserButton());

            MenuFlyout menuFlyout = new MenuFlyout();

            ToggleMenuFlyoutItem miWord = new ToggleMenuFlyoutItem();
            miWord.Text = "米字格";
            miWord.Click += (s, e) => onChangeGrid?.Invoke(s, e);

            ToggleMenuFlyoutItem tianWord = new ToggleMenuFlyoutItem();
            tianWord.Text = "田字格";
            tianWord.Click += (s, e) => onChangeGrid?.Invoke(s, e);

            ToggleMenuFlyoutItem kouWord = new ToggleMenuFlyoutItem();
            kouWord.Text = "口字格";
            kouWord.Click += (s, e) => onChangeGrid?.Invoke(s, e);

            ToggleMenuFlyoutItem clearWord = new ToggleMenuFlyoutItem();
            clearWord.Text = "五";
            clearWord.Click += (s, e) => onChangeGrid?.Invoke(s, e);

            menuFlyout.Items.Add(miWord);
            menuFlyout.Items.Add(tianWord);
            menuFlyout.Items.Add(kouWord);
            menuFlyout.Items.Add(clearWord);

            inkToolbar.Children.Add(new InkToolbarCustomToolButton()
            {
                Content = new Button()
                {
                    Content = "设",
                    Background = new SolidColorBrush(Colors.Transparent),
                    Flyout = menuFlyout
                }
            });

            //判断屏幕方向
            if (_rowNum < _colNum)
            {
                //横向
                inkToolbar.HorizontalAlignment = HorizontalAlignment.Right;
                inkToolbar.VerticalAlignment = VerticalAlignment.Center;
                inkToolbar.Orientation = Orientation.Vertical;
            }
            else
            {
                //纵向
                inkToolbar.HorizontalAlignment = HorizontalAlignment.Center;
                inkToolbar.VerticalAlignment = VerticalAlignment.Top;
            }

            return inkToolbar;
        }

        public InkCanvas GenerateInkCanvas()
        {
            InkCanvas writingInkCanvas = new InkCanvas();
            writingInkCanvas.Name = "inkCanvas";
            writingInkCanvas.InkPresenter.InputDeviceTypes =
                Windows.UI.Core.CoreInputDeviceTypes.Mouse |
                Windows.UI.Core.CoreInputDeviceTypes.Pen;

            writingInkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(new InkDrawingAttributes
            {
                Color = Colors.Black,
                IgnorePressure = false,
                FitToCurve = true
            });

            Grid.SetColumnSpan(writingInkCanvas, _colNum);
            Grid.SetRowSpan(writingInkCanvas, _rowNum);

            return writingInkCanvas;
        }

        public void GenerateWordGrid(IWordGridGenerate gridGenerate)
        {
            if (CopybookAresGrid == null)
                return;

            //判断是否已生成，已生成则重新先清空
            ClearCanvas();

            for (int i = 0; i < _rowNum; i++)
            {
                CopybookAresGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(_area) });

                for (int j = 0; j < _colNum; j++)
                {
                    CopybookAresGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(_area) });

                    Canvas canvas;

                    if (i == 0 && (j > 0 && j < (_colNum - 1)))
                    {
                        //顶部
                        canvas = gridGenerate.GenerateTopEdge(_area);
                    }
                    else if (i == 0 && j == 0)
                    {
                        //左上角
                        canvas = gridGenerate.GenerateLeftTopEdge(_area);
                    }
                    else if (j == 0 && (i > 0 && i < (_rowNum - 1)))
                    {
                        //左边
                        canvas = gridGenerate.GenerateLeftEdge(_area);
                    }
                    else if (i == 0 && j == (_colNum - 1))
                    {
                        //右上角
                        canvas = gridGenerate.GenerateRightTopEdge(_area);
                    }
                    else if (j == (_colNum - 1) && (i > 0 && i < (_rowNum - 1)))
                    {
                        //右边
                        canvas = gridGenerate.GenerateRightEdge(_area);
                    }
                    else if (j == (_colNum - 1) && i == (_rowNum - 1))
                    {
                        //右下角
                        canvas = gridGenerate.GenerateRightBottomEdge(_area);
                    }
                    else if (i == (_rowNum - 1) && (j > 0 && j < (_colNum - 1)))
                    {
                        //底部
                        canvas = gridGenerate.GenerateBottomEdge(_area);
                    }
                    else if (i == (_rowNum - 1) && j == 0)
                    {
                        //左下角
                        canvas = gridGenerate.GenerateLeftBottomEdge(_area);
                    }
                    else
                    {
                        canvas = gridGenerate.Generate(_area);
                    }

                    Grid.SetColumn(canvas, j);
                    Grid.SetRow(canvas, i);

                    _canvasList.Add(canvas);
                    CopybookAresGrid.Children.Insert(0, canvas);
                }
            }

            IsGenerateWordGrid = true;
        }

        public void GenerateWord(FontFamily fontFamily, char[] words)
        {
            if (!IsGenerateWordGrid)
                throw new NotSupportedException("没有生成格子，不能生成字");

            //判断是否已生成，已生成则重新先清空
            ClearTextBlock();

            int wordGridLasrIndex
                = CopybookAresGrid.Children.IndexOf(CopybookAresGrid.Children.Last(p => p is Canvas)) + 1;

            int col = 0, row = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (col != 0 && col % _colNum == 0)
                {
                    col = 0;
                    row++;

                    if (row > _rowNum)
                        break;
                }

                TextBlock word = new TextBlock();
                word.HorizontalAlignment = HorizontalAlignment.Center;
                word.VerticalAlignment = VerticalAlignment.Center;
                word.Opacity = 0.5;
                word.Foreground = new SolidColorBrush(Color.FromArgb(255, 68, 68, 68));
                word.FontFamily = fontFamily;
                word.FontSize = _area;
                word.Text = words[i].ToString();

                Grid.SetColumn(word, col);
                Grid.SetRow(word, row);

                _textBlockList.Add(word);
                CopybookAresGrid.Children.Insert(wordGridLasrIndex, word);

                col++;
            }
        }

        public void ClearCanvas()
        {
            foreach (var item in _canvasList)
            {
                item.Visibility = Visibility.Collapsed;
                CopybookAresGrid.Children.Remove(item);
            }

            _canvasList.Clear();
        }

        public void ClearTextBlock()
        {
            foreach (var item in _textBlockList)
            {
                item.Visibility = Visibility.Collapsed;
                CopybookAresGrid.Children.Remove(item);
            }

            _textBlockList.Clear();
        }
    }
}
