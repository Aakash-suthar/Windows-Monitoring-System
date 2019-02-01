using System.Drawing;
using System.Windows.Forms;

namespace WinOwl
{
    public partial class BlurPanel : Panel
    {

        public BlurPanel()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x0000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
        }
    }
}
