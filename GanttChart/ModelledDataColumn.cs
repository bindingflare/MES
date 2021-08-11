using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edcore.GanttChart
{
    class DataFormats
    {
        public static string DateTimeFormat = "{0:yyyy.MM.dd hh:mm:ss}";
        public static string TimeSpanFormat = @"{0:dd\.hh\:mm\:ss}";
        public static string PercentFormat = "{0:p}";
    }

    public class ModelledDataColumn : DataColumn
    {
        public object DummyValue { get; set; }
        public int DisplayIndex { get; private set; }
        public int Width { get; private set; }
        public string Text { get; private set; }
        public bool IsEditable { get; private set; }
        public bool IsVisible { get; private set; }

        public ModelledDataColumn(int displayIndex, int width, string text, bool isVisible, object dummyValue) : this(displayIndex, width, text, true, isVisible, dummyValue)
        {
        }

        public ModelledDataColumn(int displayIndex, int width, string text, bool isEditable, bool isVisible, object dummyValue)
        {
            DisplayIndex = displayIndex;
            Width = width;
            Text = text;
            IsEditable = isEditable;
            IsVisible = isVisible;
            DummyValue = dummyValue;
        }
    }
}
