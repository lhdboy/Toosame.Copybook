using Toosame.Copybook.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
            _copybookControlBuilder = new CopybookControlBuilder(13, 9, 90);

            //生成并添加画布和画布工具栏
            InkCanvas _inkCanvas = _copybookControlBuilder.GenerateInkCanvas();

            _copybookControlBuilder.SetInkToolbar(_inkCanvas, inkToolbar, toolbar, nextBtn, previousBtn);
            _copybookControlBuilder.CopybookAresGrid.Children.Add(_inkCanvas);

            writingTable.Children.Add(_copybookControlBuilder.CopybookAresGrid);


            //生成网格
            _copybookControlBuilder.GenerateWordGrid(new MiWordGridGenerate());
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string cssj = "陈胜者，阳城人也，字涉。吴广者，阳夏人也，字叔。陈涉少时，尝与人佣耕，辍耕之垄上，怅恨久之，曰：“苟富贵，无相忘。”佣者笑而应曰：“若为佣耕，何富贵也？”陈涉太息曰：“嗟乎！燕雀安知鸿鹄之志哉！”";

            _copybookControlBuilder.GenerateWord(new FontFamily("楷体"), cssj.ToCharArray());

            base.OnNavigatedTo(e);
        }

        private void WordGridChange_Click(object sender, RoutedEventArgs e)
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
            }
            else
            {
                _copybookControlBuilder.ClearCanvas();
            }
        }
    }
}
