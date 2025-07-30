using System;
using System.Collections.Generic;
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

            //contextMenuStrip1.Items.RemoveByKey("fixWindowSizeToolStripMenuItem");
            //FormBorderStyle = FormBorderStyle.FixedToolWindow;

            F1.Font = _windowFont;
            F2.Font = _windowFont;
            F3.Font = _windowFont;
            F4.Font = _windowFont;
            F5.Font = _windowFont;
            F6.Font = _windowFont;
            F7.Font = _windowFont;
            AltF1.Font = _windowFont;
            AltF2.Font = _windowFont;
            AltF3.Font = _windowFont;
            AltF4.Font = _windowFont;
            AltF5.Font = _windowFont;
            AltF6.Font = _windowFont;
            AltF7.Font = _windowFont;
            AltF8.Font = _windowFont;
            AltF9.Font = _windowFont;
            AltF10.Font = _windowFont;
            AltF11.Font = _windowFont;
            AltF12.Font = _windowFont;
            Ins.Font = _windowFont;
            PLus.Font = _windowFont;

            F1.Text = "F1 CQ";
            F2.Text = "F2 5NN NR";
            F3.Text = "F3 LOC";
            F4.Text = "F4 MYCALL";
            F5.Text = "F5 CALL";
            F6.Text = "F6 NR?";
            F7.Text = "F7 ?";

            AltF1.Text = "" + mainForm.RequestMessageString("$MSG1", "CW");
            AltF2.Text = "" + mainForm.RequestMessageString("$MSG2", "CW");
            AltF3.Text = "" + mainForm.RequestMessageString("$MSG3", "CW");
            AltF4.Text = "" + mainForm.RequestMessageString("$MSG4", "CW");
            AltF5.Text = "" + mainForm.RequestMessageString("$MSG5", "CW");
            AltF6.Text = "" + mainForm.RequestMessageString("$MSG6", "CW");
            AltF7.Text = "" + mainForm.RequestMessageString("$MSG7", "CW");
            AltF8.Text = "" + mainForm.RequestMessageString("$MSG8", "CW");
            AltF9.Text = "" + mainForm.RequestMessageString("$MSG9", "CW");
            AltF10.Text = "" + mainForm.RequestMessageString("$MSG10", "CW");
            AltF11.Text = "" + mainForm.RequestMessageString("$MSG11", "CW");
            AltF12.Text = "" + mainForm.RequestMessageString("$MSG12", "CW");

            Ins.Text = "Ins " + mainForm.RequestMessageString("$INSERT", "CW");
            PLus.Text = "Plus " + mainForm.RequestMessageString("$PLUS", "CW");

           // mainForm.SetMainStatusText("My test string: -" + mainForm.RequestMessageString("$F3", "CW") + "-");
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

        private void DXLbuttonbar_Resize(object sender, EventArgs e)
        {
            int panelHeight = ClientSize.Height / 3;
            panel1.Height = panelHeight;
            panel2.Height = panelHeight;
            panel4.Height = panelHeight;

            int buttonMargin = F1.Margin.Left;
            int buttonWidth = ClientSize.Width / 7;
            F1.Width = buttonWidth;
            F2.Width = buttonWidth;
            F3.Width = buttonWidth;
            F4.Width = buttonWidth;
            F5.Width = buttonWidth;
            F6.Width = buttonWidth;
            F7.Width = buttonWidth;
            AltF1.Width = buttonWidth;
            AltF2.Width = buttonWidth;
            AltF3.Width = buttonWidth;
            AltF4.Width = buttonWidth;
            AltF5.Width = buttonWidth;
            AltF6.Width = buttonWidth;
            AltF7.Width = buttonWidth;
            AltF8.Width = buttonWidth;
            AltF9.Width = buttonWidth;
            AltF10.Width = buttonWidth;
            AltF11.Width = buttonWidth;
            AltF12.Width = buttonWidth;
            Ins.Width = buttonWidth;
            PLus.Width = buttonWidth;
        }
    }
}
