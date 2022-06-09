﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FEBuilderGBA
{
    public partial class EventTemplate5Form : Form
    {
        public EventTemplate5Form()
        {
            InitializeComponent();
            FormIcon.Image = SystemIcons.Question.ToBitmap();
            U.AddCancelButton(this);
        }

        private void EventCondEventTemplate5Form_Load(object sender, EventArgs e)
        {

        }
        public void Init(List<Control> controls)
        {
            this.ParentControls = controls;
        }
        List<Control> ParentControls;
        public byte[] GenCode = null;
        public uint CallEventAddr = U.NOT_FOUND;
        public bool NeedFlag03 = false;

        private void BLANK_Button_Click(object sender, EventArgs e)
        {
            this.GenCode = Program.ROM.RomInfo.Default_event_script_toplevel_code;
            this.Close();
        }

        private void CALL_EndEvent_button_Click(object sender, EventArgs e)
        {
            uint mapid = EventCondForm.GetMapID(this.ParentControls);
            this.CallEventAddr = EventCondForm.GetEndEvent(mapid);
            this.NeedFlag03 = true;
            this.Close();
        }
        private void CALL_1_button_Click(object sender, EventArgs e)
        {
            this.CallEventAddr = 1;
            this.Close();
        }
    }
}
