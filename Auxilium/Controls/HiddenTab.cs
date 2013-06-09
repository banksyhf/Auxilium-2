using System;
using System.Windows.Forms;

namespace Auxilium.Controls
{
    public class HiddenTab : TabControl
    {
        public int DesignerIndex
        {
            get { return SelectedIndex; }
            set
            {
                if (DesignMode)
                    SelectedIndex = value;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 4904)
                m.Result = IntPtr.Zero;
            else
                base.WndProc(ref m);
        }
    }
}