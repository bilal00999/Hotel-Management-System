using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace HotelManagementSystem.Controls
{
    // Custom Button with Rounded Corners
    public class RoundedButton : Button
    {
        private int borderRadius = 10;
        private Color borderColor = Color.FromArgb(52, 152, 219);
        private Color hoverColor = Color.FromArgb(41, 128, 185);
        private Color pressedColor = Color.FromArgb(31, 97, 141);

        [Category("Appearance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value; }
        }

        [Category("Appearance")]
        public Color PressedColor
        {
            get { return pressedColor; }
            set { pressedColor = value; }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(52, 152, 219);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.Size = new Size(120, 40);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = GetRoundedRectangle(this.ClientRectangle, borderRadius);
            this.Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            using (Pen pen = new Pen(borderColor, 2))
            {
                pevent.Graphics.DrawPath(pen, path);
            }

            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font,
                this.ClientRectangle, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = hoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.FromArgb(52, 152, 219);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = pressedColor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = hoverColor;
        }
    }

    // Custom TextBox with Placeholder
    public class PlaceholderTextBox : TextBox
    {
        private string placeholderText = "Enter text...";
        private bool isPlaceholderActive = true;

        [Category("Appearance")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; SetPlaceholder(); }
        }

        [Category("Appearance")]
        public Color PlaceholderColor { get; set; } = Color.Gray;

        [Category("Appearance")]
        public Color TextColor { get; set; } = Color.Black;

        public PlaceholderTextBox()
        {
            this.Font = new Font("Segoe UI", 10);
            SetPlaceholder();
            this.Enter += RemovePlaceholder;
            this.Leave += SetPlaceholder;
        }

        private void SetPlaceholder(object sender = null, EventArgs e = null)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                isPlaceholderActive = true;
                this.Text = placeholderText;
                this.ForeColor = PlaceholderColor;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive && this.Text == placeholderText)
            {
                isPlaceholderActive = false;
                this.Text = "";
                this.ForeColor = TextColor;
            }
        }

        public override string Text
        {
            get
            {
                if (isPlaceholderActive)
                    return "";
                return base.Text;
            }
            set
            {
                base.Text = value;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    isPlaceholderActive = false;
                    this.ForeColor = TextColor;
                }
                else
                {
                    SetPlaceholder();
                }
            }
        }
    }

    // Custom Panel with Gradient Background
    public class GradientPanel : Panel
    {
        private Color gradientStartColor = Color.FromArgb(52, 152, 219);
        private Color gradientEndColor = Color.FromArgb(41, 128, 185);
        private float gradientAngle = 90;

        [Category("Appearance")]
        public Color GradientStartColor
        {
            get { return gradientStartColor; }
            set { gradientStartColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color GradientEndColor
        {
            get { return gradientEndColor; }
            set { gradientEndColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; Invalidate(); }
        }

        public GradientPanel()
        {
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, gradientStartColor, gradientEndColor, gradientAngle))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }

    // Custom Card Panel with Shadow
    public class CardPanel : Panel
    {
        private int cornerRadius = 10;
        private int shadowDepth = 5;

        [Category("Appearance")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        public int ShadowDepth
        {
            get { return shadowDepth; }
            set { shadowDepth = value; Invalidate(); }
        }

        public CardPanel()
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw shadow
            for (int i = 1; i <= shadowDepth; i++)
            {
                Rectangle shadowRect = new Rectangle(
                    this.ClientRectangle.X + i,
                    this.ClientRectangle.Y + i,
                    this.ClientRectangle.Width - i,
                    this.ClientRectangle.Height - i);

                using (GraphicsPath path = GetRoundedRectangle(shadowRect, cornerRadius))
                using (Pen pen = new Pen(Color.FromArgb(50, 0, 0, 0), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Draw main card
            using (GraphicsPath path = GetRoundedRectangle(this.ClientRectangle, cornerRadius))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            using (Pen borderPen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(borderPen, path);
            }

            base.OnPaint(e);
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    // Custom Numeric TextBox (Only Numbers)
    public class NumericTextBox : TextBox
    {
        private bool allowDecimal = true;
        private int decimalPlaces = 2;

        [Category("Behavior")]
        public bool AllowDecimal
        {
            get { return allowDecimal; }
            set { allowDecimal = value; }
        }

        [Category("Behavior")]
        public int DecimalPlaces
        {
            get { return decimalPlaces; }
            set { decimalPlaces = value; }
        }

        [Category("Behavior")]
        public decimal Minimum { get; set; } = decimal.MinValue;

        [Category("Behavior")]
        public decimal Maximum { get; set; } = decimal.MaxValue;

        public decimal NumericValue
        {
            get
            {
                if (decimal.TryParse(this.Text, out decimal value))
                    return value;
                return 0;
            }
            set
            {
                this.Text = value.ToString(GetFormatString());
            }
        }

        private string GetFormatString()
        {
            if (allowDecimal && decimalPlaces > 0)
                return "F" + decimalPlaces;
            return "F0";
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsControl(e.KeyChar))
            {
                if (allowDecimal && e.KeyChar == '.')
                {
                    if (this.Text.Contains("."))
                        e.Handled = true;
                }
                else if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (!string.IsNullOrWhiteSpace(this.Text))
            {
                if (decimal.TryParse(this.Text, out decimal value))
                {
                    value = Math.Max(Minimum, Math.Min(Maximum, value));
                    this.Text = value.ToString(GetFormatString());
                }
                else
                {
                    this.Text = "0";
                }
            }
            else
            {
                this.Text = "0";
            }
        }
    }

    // Custom DataGridView with Search and Filter
    public class SearchableDataGridView : DataGridView
    {
        private TextBox searchBox;
        private string currentFilter = "";

        [Category("Behavior")]
        public bool EnableSearch { get; set; } = true;

        [Category("Appearance")]
        public Color SearchHighlightColor { get; set; } = Color.Yellow;

        public SearchableDataGridView()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ReadOnly = true;
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void AddSearchBox(Control parent, Point location, Size size)
        {
            if (!EnableSearch) return;

            searchBox = new TextBox();
            searchBox.Location = location;
            searchBox.Size = size;
            searchBox.Font = new Font("Segoe UI", 10);
            searchBox.TextChanged += SearchBox_TextChanged;
            parent.Controls.Add(searchBox);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            currentFilter = searchBox.Text.ToLower();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (string.IsNullOrWhiteSpace(currentFilter))
            {
                this.ClearSelection();
                return;
            }

            foreach (DataGridViewRow row in this.Rows)
            {
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(currentFilter))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    row.Visible = true;
                    row.DefaultCellStyle.BackColor = SearchHighlightColor;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        public void ResetSearch()
        {
            if (searchBox != null)
            {
                searchBox.Text = "";
            }
            foreach (DataGridViewRow row in this.Rows)
            {
                row.Visible = true;
                row.DefaultCellStyle.BackColor = this.DefaultCellStyle.BackColor;
            }
        }
    }

    // Custom Loading Spinner
    public class LoadingSpinner : Control
    {
        private Timer animationTimer;
        private int angle = 0;
        private int spinnerSize = 30;
        private int speed = 10;

        [Category("Appearance")]
        public int SpinnerSize
        {
            get { return spinnerSize; }
            set { spinnerSize = value; this.Size = new Size(value, value); Invalidate(); }
        }

        [Category("Behavior")]
        public int Speed
        {
            get { return speed; }
            set { speed = Math.Max(1, Math.Min(50, value)); }
        }

        [Category("Appearance")]
        public Color SpinnerColor { get; set; } = Color.FromArgb(52, 152, 219);

        public LoadingSpinner()
        {
            this.Size = new Size(spinnerSize, spinnerSize);
            this.BackColor = Color.Transparent;
            this.Visible = false;

            animationTimer = new Timer();
            animationTimer.Interval = speed;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        public void Start()
        {
            this.Visible = true;
            angle = 0;
            animationTimer.Start();
        }

        public void Stop()
        {
            animationTimer.Stop();
            this.Visible = false;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            angle = (angle + 30) % 360;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!this.Visible) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(2, 2, this.Width - 4, this.Height - 4);

            using (Pen pen = new Pen(SpinnerColor, 3))
            using (Pen backPen = new Pen(Color.FromArgb(100, SpinnerColor), 2))
            {
                // Draw background arc
                e.Graphics.DrawArc(backPen, rect, 0, 360);

                // Draw spinning arc
                e.Graphics.DrawArc(pen, rect, angle, 270);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && animationTimer != null)
            {
                animationTimer.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}