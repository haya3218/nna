using BrightIdeasSoftware;
using System.Drawing;
using System.Windows.Forms;

namespace nna_net3.src.objects
{
    public class ColumnNameSize
    {
        public int ColumnSize = 120;
        public string ColumnName = "Default";
        public bool TakesUp = false;
        public bool ButtonCol = false;
        public int ButtonX = 0;
        public int ButtonY = 0;
        public bool Editable = true;
        public bool Searchable = false;
        public HorizontalAlignment Alignment = HorizontalAlignment.Left;
        public string Aspect = "n0n3";
        public BaseRenderer Renderer;

        public ColumnNameSize(int size, string name, string aspect, bool fills, bool button, Point buttonSize, bool editable = true, bool search = true, HorizontalAlignment alignment = HorizontalAlignment.Left, BaseRenderer renderer = null)
        {
            ColumnSize = size;
            ColumnName = name;
            Aspect = aspect;
            TakesUp = fills;
            ButtonCol = button;
            ButtonX = buttonSize.X;
            ButtonY = buttonSize.Y;
            Editable = editable;
            Searchable = search;
            Alignment = alignment;
            Renderer = renderer;
        }

        public ColumnNameSize(int size, string name, string aspect, bool fills, bool editable = true, bool search = true, HorizontalAlignment alignment = HorizontalAlignment.Left, BaseRenderer renderer = null)
        {
            ColumnSize = size;
            ColumnName = name;
            Aspect = aspect;
            TakesUp = fills;
            Editable = editable;
            Searchable = search;
            Alignment = alignment;
            Renderer = renderer;
        }

        public ColumnNameSize(int size, string name, string aspect, bool fills, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            ColumnSize = size;
            ColumnName = name;
            Aspect = aspect;
            TakesUp = fills;
            Alignment = alignment;
        }

        public ColumnNameSize(int size, string name, string aspect, bool fills, HorizontalAlignment alignment, BaseRenderer renderer)
        {
            ColumnSize = size;
            ColumnName = name;
            Aspect = aspect;
            TakesUp = fills;
            Alignment = alignment;
            Renderer = renderer;
        }
    }
}