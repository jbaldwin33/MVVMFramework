using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static MVVMFramework.Controls.TextBoxUtilities;

namespace MVVMFramework.Controls
{
    public static class TextBoxUtilities
    {
        internal static ControlTemplate SetTemplateContent<T>() where T : Control
        {
            var template = new ControlTemplate(typeof(T));
            var scrollViewer = new FrameworkElementFactory(typeof(ScrollViewer)) { Name = "PART_ContentHost" };
            var border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.CornerRadiusProperty, new TemplateBindingExtension(Border.CornerRadiusProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(Border.PaddingProperty));
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Border.BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(Border.BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(Border.BorderThicknessProperty));
            scrollViewer.SetValue(FrameworkElement.NameProperty, new TemplateBindingExtension(FrameworkElement.NameProperty));
            scrollViewer.SetValue(ContentControl.ContentProperty, new TemplateBindingExtension(ContentControl.ContentProperty));
            scrollViewer.SetValue(ScrollViewer.CanContentScrollProperty, new TemplateBindingExtension(ScrollViewer.CanContentScrollProperty));
            scrollViewer.SetValue(FrameworkElement.HorizontalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.HorizontalAlignmentProperty));
            scrollViewer.SetValue(FrameworkElement.VerticalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.VerticalAlignmentProperty));
            border.AppendChild(scrollViewer);
            template.VisualTree = border;
            return template;
        }
    }

    public abstract class DefaultTextBox : TextBox
    {
        protected DefaultTextBox()
        {
            Template = SetTemplateContent<DefaultTextBox>();
            HorizontalAlignment = HorizontalAlignment.Left;
            Padding = new Thickness(0, -3, 0, 0);
            Margin = new Thickness(10, 0, 10, 10);
            var myResourceDictionary = new ResourceDictionary
            {
                Source = new Uri("/MVVMFramework;component/Controls/ControlStyles.xaml", UriKind.RelativeOrAbsolute)
            };

            Background = myResourceDictionary["WindowBackgroundBrush"] as SolidColorBrush;
            BorderBrush = myResourceDictionary["SolidBorderBrush"] as SolidColorBrush;
            BorderThickness = new Thickness(1);
        }
    }

    public class SmallTextBox : DefaultTextBox
    {
        public SmallTextBox()
        {
            Width = 50;
            Height = 20;
            FontSize = 15;
        }

        static SmallTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmallTextBox), new FrameworkPropertyMetadata(typeof(SmallTextBox)));
        }
    }

    public class MediumTextBox : DefaultTextBox
    {
        public MediumTextBox()
        {
            Width = 100;
            Height = 25;
            FontSize = 20;
        }

        static MediumTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediumTextBox), new FrameworkPropertyMetadata(typeof(MediumTextBox)));
        }
    }

    public class LargeTextBox : DefaultTextBox
    {
        public LargeTextBox()
        {
            Width = 150;
            Height = 30;
            FontSize = 25;
        }

        static LargeTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LargeTextBox), new FrameworkPropertyMetadata(typeof(LargeTextBox)));
        }
    }
}