using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MVVMFramework.Controls
{
    public static class StackPanelUtilities
    {
        public static ControlTemplate SetTemplate()
        {
            var template = new ControlTemplate(typeof(StackPanel));
            var contentControl = new FrameworkElementFactory(typeof(ContentControl));
            contentControl.SetValue(StackPanel.OrientationProperty, new TemplateBindingExtension(StackPanel.OrientationProperty));
            contentControl.SetValue(FrameworkElement.HorizontalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.HorizontalAlignmentProperty));
            contentControl.SetValue(FrameworkElement.VerticalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.VerticalAlignmentProperty));
            contentControl.SetValue(FrameworkElement.MarginProperty, new TemplateBindingExtension(Control.PaddingProperty));
            contentControl.SetValue(Control.PaddingProperty, new TemplateBindingExtension(Control.PaddingProperty));
            template.VisualTree = contentControl;
            return template;
        }
    }
    public class DefaultStackPanel : StackPanel
    {
        public DefaultStackPanel()
        {
            Orientation = Orientation.Horizontal;
            HorizontalAlignment = HorizontalAlignment.Left;
            VerticalAlignment = VerticalAlignment.Top;
        }

        static DefaultStackPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DefaultStackPanel), new FrameworkPropertyMetadata(typeof(DefaultStackPanel)));
        }
    }
}
