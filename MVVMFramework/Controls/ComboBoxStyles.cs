using System.Windows;
using System.Windows.Controls;

namespace MVVMFramework.Controls
{
    public class DefaultComboBox : ComboBox
    {
        public DefaultComboBox()
        {
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(10, 0, 10, 10);
            Padding = new Thickness(5);
        }

        static DefaultComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DefaultComboBox), new FrameworkPropertyMetadata(typeof(DefaultComboBox)));
        }
    }
    public class ExtraSmallComboBox : DefaultComboBox
    {
        public ExtraSmallComboBox()
        {
            Width = 50;
            Height = 25;
        }

        static ExtraSmallComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraSmallComboBox), new FrameworkPropertyMetadata(typeof(ExtraSmallComboBox)));
        }
    }

    public class SmallComboBox : DefaultComboBox
    {
        public SmallComboBox()
        {
            Width = 75;
            Height = 25;
        }

        static SmallComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallComboBox), new FrameworkPropertyMetadata(typeof(SmallComboBox)));
        }
    }

    public class MediumComboBox : DefaultComboBox
    {
        public MediumComboBox()
        {
            Width = 100;
            Height = 25;
        }

        static MediumComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumComboBox), new FrameworkPropertyMetadata(typeof(MediumComboBox)));
        }
    }

    public class LargeComboBox : DefaultComboBox
    {
        public LargeComboBox()
        {
            Width = 125;
            Height = 25;
        }

        static LargeComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeComboBox), new FrameworkPropertyMetadata(typeof(LargeComboBox)));
        }
    }

    public class ExtraLargeComboBox : DefaultComboBox
    {
        public ExtraLargeComboBox()
        {
            Width = 150;
            Height = 25;
        }

        static ExtraLargeComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraLargeComboBox), new FrameworkPropertyMetadata(typeof(ExtraLargeComboBox)));
        }
    }
}
