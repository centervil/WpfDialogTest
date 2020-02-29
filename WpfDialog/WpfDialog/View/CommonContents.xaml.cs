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
        public static readonly DependencyProperty TitleProperty = RegisterDependency(nameof(Title), typeof(string));
        public static readonly DependencyProperty SubTitleProperty = RegisterDependency(nameof(SubTitle), typeof(string));

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

        private static DependencyProperty RegisterDependency(string propertyName, Type propertyType)
        {
            return DependencyProperty.Register(propertyName, propertyType, typeof(CommonContents),
                new FrameworkPropertyMetadata(propertyName, new PropertyChangedCallback(OnDependencyPropertyChanged)));
        }

        private static void OnDependencyPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            CommonContents ctrl = obj as CommonContents;
            if (ctrl != null)
            {
                if (e.Property.Name == nameof(Title))
                {
                    ctrl.TitleText.Text = ctrl.Title;
                }
                if (e.Property.Name == nameof(SubTitle))
                {
                    ctrl.SubTitleText.Text = ctrl.SubTitle;
                }
            }
        }

        public CommonContents()
        {
            InitializeComponent();
        }
    }
}
