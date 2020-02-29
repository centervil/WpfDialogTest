using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDialog.View
{
    /// <summary>
    /// CommonContents.xaml の相互作用ロジック
    /// </summary>
    public partial class CommonContents : UserControl
    {
        // 1. 依存プロパティの作成
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title),
                                        typeof(string),
                                        typeof(CommonContents),
                                        new FrameworkPropertyMetadata(nameof(Title), new PropertyChangedCallback(OnTitleChanged)));
        public static readonly DependencyProperty SubTitleProperty =
            DependencyProperty.Register(nameof(SubTitle),
                                        typeof(string),
                                        typeof(CommonContents),
                                        new FrameworkPropertyMetadata(nameof(SubTitle), new PropertyChangedCallback(OnSubTitleChanged)));

        // 2. CLI用プロパティを提供するラッパー
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string SubTitle
        {
            get { return (string)GetValue(SubTitleProperty); }
            set { SetValue(SubTitleProperty, value); }
        }

        // 3. 依存プロパティが変更されたとき呼ばれるコールバック関数の定義
        private static void OnTitleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            // オブジェクトを取得して処理する
            CommonContents ctrl = obj as CommonContents;
            if (ctrl != null)
            {
                ctrl.TitleText.Text = ctrl.Title;
            }
        }
        private static void OnSubTitleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            // オブジェクトを取得して処理する
            CommonContents ctrl = obj as CommonContents;
            if (ctrl != null)
            {
                ctrl.SubTitleText.Text = ctrl.SubTitle;
            }
        }
        public CommonContents()
        {
            InitializeComponent();
        }
    }
}
