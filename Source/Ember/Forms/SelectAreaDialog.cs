using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ember.Forms
{
    public sealed partial class SelectAreaDialog : Form
    {
        public Rectangle SelectedArea { get; set; }
        private Point startLocation;
        private bool shouldPaint;

        // These resources are instantiated as the class-level to avoid the cost of 
        // instantiation in paint-inducing methods.
        private readonly Brush fillBrush = new SolidBrush(Color.FromArgb(50, 30, 130, 255));
        private readonly Pen borderPen = new Pen(Color.FromArgb(50, 204, 229, 255));

        public SelectAreaDialog(Image screenshot)
        {
            InitializeComponent();

            Bounds = SystemInformation.VirtualScreen;
            BackgroundImage = screenshot;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startLocation = e.Location;
                shouldPaint = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (shouldPaint)
            {
                SelectedArea = new Rectangle(
                    Math.Min(startLocation.X, e.X),
                    Math.Min(startLocation.Y, e.Y),
                    Math.Abs(startLocation.X - e.X),
                    Math.Abs(startLocation.Y - e.Y));

                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(fillBrush, SelectedArea);
            e.Graphics.DrawRectangle(borderPen, SelectedArea);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}