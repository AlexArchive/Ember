using System.Windows.Forms;
using Shortcut;

namespace Screenshot.Forms
{
    public partial class MainForm : Form
    {
        private HotkeyBinder binder = new HotkeyBinder();

        public MainForm()
        {
            InitializeComponent();
            binder.Bind(Modifiers.Control,Keys.A).To(()=> new SelectAreaDialog().ShowDialog());
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }
    }
}
