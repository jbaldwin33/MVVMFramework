using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using MVVMFrameworkNet472.Controls;

namespace TestApp
{
    public class MyTickBar : TickBar
    {
        protected override void OnRender(DrawingContext dc)
        {
            Size size = new Size(base.ActualWidth, base.ActualHeight);

            int tickCount = (int)((this.Maximum - this.Minimum) / this.TickFrequency) + 1;

            if ((this.Maximum - this.Minimum) % this.TickFrequency == 0)

                tickCount -= 1;
            Double tickFrequencySize;
            // Calculate tick's setting
            tickFrequencySize = (size.Width * this.TickFrequency / (this.Maximum - this.Minimum));
            string text = "";
            FormattedText formattedText = null;
            double num = this.Maximum - this.Minimum;
            int i = 0;
            // Draw each tick text
            for (i = 0; i <= tickCount; i++)
            {
                text = Convert.ToString(Convert.ToInt32(this.Minimum + this.TickFrequency * i), 10);
                //g.DrawString(text, font, brush, drawRect.Left + tickFrequencySize * i, drawRect.Top + drawRect.Height/2, stringFormat);
                formattedText = new FormattedText(text, CultureInfo.GetCultureInfo("en-us"), FlowDirection.LeftToRight, new Typeface("Verdana"), 8, Brushes.Black, 1.25);
                dc.DrawText(formattedText, new Point((tickFrequencySize * i), 30));
            }
        }
    }
    public class SliderWithLabels : Slider
    {
        static ControlTemplate SetTemplateContent<T>() where T : Control
        {
            var template = new ControlTemplate(typeof(T));
            var scrollViewer = new FrameworkElementFactory(typeof(ScrollViewer))
            {
                Name = "PART_ContentHost"
            };
            var border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.CornerRadiusProperty, new TemplateBindingExtension(Border.CornerRadiusProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(Border.PaddingProperty));
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Border.BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(Border.BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(Border.BorderThicknessProperty));
            scrollViewer.SetValue(NameProperty, new TemplateBindingExtension(NameProperty));
            scrollViewer.SetValue(ContentControl.ContentProperty, new TemplateBindingExtension(ContentControl.ContentProperty));
            scrollViewer.SetValue(ScrollViewer.CanContentScrollProperty, new TemplateBindingExtension(ScrollViewer.CanContentScrollProperty));
            scrollViewer.SetValue(FrameworkElement.HorizontalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.HorizontalAlignmentProperty));
            scrollViewer.SetValue(FrameworkElement.VerticalAlignmentProperty, new TemplateBindingExtension(FrameworkElement.VerticalAlignmentProperty));
            border.AppendChild(scrollViewer);
            template.VisualTree = border;
            return template;
        }

        public SliderWithLabels() 
        {

        }

        static SliderWithLabels()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SliderWithLabels), new FrameworkPropertyMetadata(typeof(SliderWithLabels)));
        }
    }
}
