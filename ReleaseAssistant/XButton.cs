using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ReleaseAssistant
{
    class XButton : Button
    {
        private int _value = 0;

        [Browsable(true)]
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                base.Text = value + "";
            }
        }

        public override string Text
        {
            get { return _value + ""; }
            set
            {
                int _value;
                if (int.TryParse(value, out _value))
                    this.Value = _value;
            }
        }

        [Browsable(true)]
        public bool IncreaseOnClick { get; set; } = true;

        public void Increase()
        {
            Value++;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (IncreaseOnClick)
                Increase();
        }
    }
}
