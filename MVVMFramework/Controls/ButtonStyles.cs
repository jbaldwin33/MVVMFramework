using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using static MVVMFramework.Controls.ControlUtilities;
using static MVVMFramework.Controls.ButtonUtilities;

namespace MVVMFramework.Controls
{
    public static class ButtonUtilities
    {
        internal static Trigger[] CreateButtonTriggers() =>
            new[]
            {
                CreateTrigger(UIElement.IsMouseOverProperty, true, new [] { CreateSetter(Control.BackgroundProperty, Brushes.CadetBlue) }),
                CreateTrigger(UIElement.IsMouseOverProperty, false, new [] { CreateSetter(Control.BorderBrushProperty, Brushes.Transparent), CreateSetter(Control.BackgroundProperty, Brushes.DarkGray) }),
                CreateTrigger(ButtonBase.IsPressedProperty, true, new [] { CreateSetter(Control.BorderBrushProperty, Brushes.Transparent), CreateSetter(UIElement.OpacityProperty, 0.8) }),
                CreateTrigger(UIElement.IsEnabledProperty, false, new [] { CreateSetter(Control.BackgroundProperty, Brushes.LightGray), CreateSetter(UIElement.OpacityProperty, 0.5), CreateSetter(ContentControl.ContentProperty, Brushes.LightGray)})
            };

        internal static Setter[] CreateButtonSetters() =>
            new[]
            {
                CreateSetter(Border.CornerRadiusProperty, new CornerRadius(8))
            };
    }

    public class DefaultButton : Button
    {
        public DefaultButton()
        {
            Template = SetTemplateContent<DefaultButton>();
            Style = SetStyle(CreateButtonSetters(), CreateButtonTriggers());
            HorizontalAlignment = HorizontalAlignment.Center;
            VerticalAlignment = VerticalAlignment.Center;
            HorizontalContentAlignment = HorizontalAlignment.Center;
            VerticalContentAlignment = VerticalAlignment.Center;
            Margin = new Thickness(5, 0, 5, 15);
            Padding = new Thickness(5);
            Height = 30;
            MinWidth = 50;
        }
    }

    public class ExtraSmallButton : DefaultButton
    {
        public ExtraSmallButton()
        {
            Width = 50;
            Height = 30;
        }

        static ExtraSmallButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraSmallButton), new FrameworkPropertyMetadata(typeof(ExtraSmallButton)));
        }
    }

    public class SmallButton : DefaultButton
    {
        public SmallButton()
        {
            Width = 75;
            Height = 30;
        }

        static SmallButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallButton), new FrameworkPropertyMetadata(typeof(SmallButton)));
        }
    }

    public class MediumButton : DefaultButton
    {
        public MediumButton()
        {
            Width = 100;
            Height = 30;
        }

        static MediumButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumButton), new FrameworkPropertyMetadata(typeof(MediumButton)));
        }
    }

    public class LargeButton : DefaultButton
    {
        public LargeButton()
        {
            Width = 125;
            Height = 30;
        }

        static LargeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeButton), new FrameworkPropertyMetadata(typeof(LargeButton)));
        }
    }

    public class ExtraLargeButton : DefaultButton
    {
        public ExtraLargeButton()
        {
            Width = 150;
            Height = 30;
        }

        static ExtraLargeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraLargeButton), new FrameworkPropertyMetadata(typeof(ExtraLargeButton)));
        }
    }
}
