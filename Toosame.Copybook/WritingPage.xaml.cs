using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Toosame.Copybook.CopybookGrid;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Toosame.Copybook
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class WritingPage : Page
    {
        private readonly CopybookControlBuilder _copybookControlBuilder;

        public WritingPage()
        {
            this.InitializeComponent();

            //初始化字帖控件
            _copybookControlBuilder = new CopybookControlBuilder(9, 13, 90);

            //生成并添加画布和画布工具栏
            InkCanvas _inkCanvas = _copybookControlBuilder.GenerateInkCanvas();
            _copybookControlBuilder.CopybookAresGrid.Children.Add(_inkCanvas);

            writingTable.Children.Add(_copybookControlBuilder.CopybookAresGrid);
            writingTable.Children.Add(_copybookControlBuilder.GenerateInkToolbar(_inkCanvas, Button_Click));


            //生成网格
            _copybookControlBuilder.GenerateWordGrid(new MiWordGridGenerate());
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string cssj = "陈胜者，阳城人也，字涉。吴广者，阳夏人也，字叔。陈涉少时，尝与人佣耕，辍耕之垄上，怅恨久之，曰：“苟富贵，无相忘。”佣者笑而应曰：“若为佣耕，何富贵也？”陈涉太息曰：“嗟乎！燕雀安知鸿鹄之志哉！”";

            //string[] words = new string[] { "寥", "落", "古", "行", "宫", "，", "宫", "花", "寂", "寞", "红" };
            _copybookControlBuilder.GenerateWord(new FontFamily("Assets/Fonts/HYXingKaiJ.ttf#HYXingKaiJ"), cssj.ToCharArray());

            base.OnNavigatedTo(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem menuFlyoutItem = sender as MenuFlyoutItem;
            if (menuFlyoutItem.Text == "米字格")
            {
                _copybookControlBuilder.GenerateWordGrid(new MiWordGridGenerate());
            }
            else if (menuFlyoutItem.Text == "田字格")
            {
                _copybookControlBuilder.GenerateWordGrid(new TianWordGridGenerate());
            }
            else if (menuFlyoutItem.Text == "口字格")
            {
                _copybookControlBuilder.GenerateWordGrid(new KouWordGridGenerate());
            } else
            {
                _copybookControlBuilder.ClearCanvas();
            }
        }
    }
}
