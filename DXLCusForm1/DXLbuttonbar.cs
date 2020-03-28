using System;
using System.Drawing;
using System.Windows.Forms;

namespace DXLog.net
{
    public partial class DXLbuttonbar : KForm
    {
        public static string CusWinName
        {
            get { return "Message button bar"; }
        }

        public static int CusFormID
        {
            get { return 1021; }
        }
        
        private Font _windowFont = new Font("Courier New", 10, FontStyle.Regular);

        private FrmMain mainForm = null;

        private delegate void newQsoSaved(DXQSO qso);

        public DXLbuttonbar()
        {
            InitializeComponent();
        }

        public DXLbuttonbar(ContestData cdata)
        {
            InitializeComponent();
            ColorSetTypes = new string[] { "Background", "Color", "Header back color", "Header color", "Footer back color", "Footer color", "Final score color", "Selection back color", "Selection color" };
            DefaultColors = new Color[] { Color.Turquoise, Color.Black, Color.Gray, Color.Black, Color.Silver, Color.Black, Color.Blue, Color.SteelBlue, Color.White };
            FormLayoutChangeEvent += new FormLayoutChange(Handle_FormLayoutChangeEvent);
        }

        private void Handle_FormLayoutChangeEvent()
        {
            InitializeLayout();
        }

        public override void InitializeLayout()
        {
            InitializeLayout(_windowFont);
            if (FormLayout.FontName.Contains("Courier"))
                _windowFont = new Font(FormLayout.FontName, FormLayout.FontSize, FontStyle.Regular);
            else
                _windowFont = Helper.GetSpecialFont(FontStyle.Regular, FormLayout.FontSize);

            if (mainForm == null)
            {
                mainForm = (FrmMain)(ParentForm ?? Owner);
            }

            contextMenuStrip1.Items.RemoveByKey("fixWindowSizeToolStripMenuItem");
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        // Valid arguments for SendKeyMessage are F1-F7, INSERT, PLUS, and ALTF1-F12.

        private void F1_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F1");
        }

        private void F2_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F2");
        }

        private void F3_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F3");
        }

        private void F4_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F4");
        }

        private void F5_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F5");
        }

        private void F6_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F6");
        }

        private void F7_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "F7");
        }

        private void Ins_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "INSERT");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "PLUS");
        }

        private void AltF1_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF1");
        }

        private void AltF2_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF2");
        }

        private void AltF3_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF3");
        }

        private void AltF4_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF4");
        }

        private void AltF5_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF5");
        }

        private void AltF6_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF6");
        }

        private void AltF7_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF7");
        }

        private void AltF8_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF8");
        }

        private void AltF9_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF9");
        }

        private void AltF10_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF10");
        }

        private void AltF11_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF11");
        }

        private void AltF12_Click(object sender, EventArgs e)
        {
            mainForm.SendKeyMessage(false, "ALTF12");
        }
    }
}
