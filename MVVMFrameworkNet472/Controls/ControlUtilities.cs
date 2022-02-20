using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Brushes = System.Windows.Media.Brushes;

namespace MVVMFrameworkNet472.Controls
{
    public partial class WindowStyle : ResourceDictionary
    {
        public WindowStyle()
        {
            InitializeComponent();
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }

        private void MaximizeRestoreClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            if (window.WindowState == WindowState.Normal)
                window.WindowState = WindowState.Maximized;
            else
                window.WindowState = WindowState.Normal;
        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = WindowState.Minimized;
        }
    }
    public class ControlUtilities
    {
        internal static ControlTemplate SetTemplateContent<T>() where T : Control
        {
            var template = new ControlTemplate(typeof(T));
            var contentControl = new FrameworkElementFactory(typeof(ContentControl));
            var border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Border.BackgroundProperty));
            border.SetValue(Border.CornerRadiusProperty, new TemplateBindingExtension(Border.CornerRadiusProperty));
            contentControl.SetValue(ContentControl.ContentProperty, new TemplateBindingExtension(ContentControl.ContentProperty));
            contentControl.SetValue(FrameworkElement.HorizontalAlignmentProperty, new TemplateBindingExtension(Control.HorizontalContentAlignmentProperty));
            contentControl.SetValue(FrameworkElement.VerticalAlignmentProperty, new TemplateBindingExtension(Control.VerticalContentAlignmentProperty));
            contentControl.SetValue(FrameworkElement.MarginProperty, new TemplateBindingExtension(Control.PaddingProperty));
            contentControl.SetValue(Control.PaddingProperty, new TemplateBindingExtension(Control.PaddingProperty));
            border.AppendChild(contentControl);
            template.VisualTree = border;
            return template;
        }

        internal static Style SetStyle(Setter[] setters, Trigger[] triggers)
        {
            var style = new Style();
            for (var i = 0; i < triggers.Length; i++)
                style.Triggers.Add(triggers[i]);
            for (var i = 0; i < setters.Length; i++)
                style.Setters.Add(setters[i]);
            return style;
        }

        internal static Style AddStyleWithTriggers()
        {
            return new Style
            {
                Triggers =
                {
                    CreateTrigger(UIElement.IsMouseOverProperty, true, new[] { CreateSetter(Control.BackgroundProperty, Brushes.CadetBlue) }),
                    CreateTrigger(UIElement.IsMouseOverProperty, false, new[] { CreateSetter(Control.BorderBrushProperty, Brushes.Transparent), CreateSetter(Control.BackgroundProperty, Brushes.DarkGray) }),
                    CreateTrigger(ButtonBase.IsPressedProperty, true, new [] { CreateSetter(Control.BorderBrushProperty, Brushes.Transparent), CreateSetter(UIElement.OpacityProperty, 0.8) })
                }
            };
        }

        internal static Trigger CreateTrigger(DependencyProperty prop, object value, Setter[] setters)
        {
            var trigger = new Trigger { Property = prop, Value = value };
            foreach (var setter in setters)
                trigger.Setters.Add(setter);
            return trigger;
        }

        internal static Setter CreateSetter(DependencyProperty prop, object value, string targetName = null) => new Setter { Property = prop, Value = value, TargetName = targetName };
    }
}
