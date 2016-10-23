﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace SciChart.Wpf.UI.Controls.AttachedBehaviours
{
    public class TextElementEx
    {
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached(
            "Foreground", typeof (Brush), typeof (TextElementEx), new PropertyMetadata(default(Brush)));

        public static void SetForeground(DependencyObject element, Brush value)
        {
            element.SetValue(ForegroundProperty, value);
        }

        public static Brush GetForeground(DependencyObject element)
        {
            return (Brush) element.GetValue(ForegroundProperty);
        }
    }
}
