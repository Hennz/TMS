using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class ShiftAddEditForm : Form
    {
        MasterController _controller;

        Member member;

        public ShiftAddEditForm(MasterController c, Member m)
        {
            InitializeComponent();

            _controller = c;
            member = m;

            Text = "Shift for " + (member.lName + ", " + member.fName);

            if (member.assignedShifts.Count == 3)
            {
                dtpStart1.Value = member.assignedShifts[0].startTime;
                dtpEnd1.Value = member.assignedShifts[0].endTime;

                dtpStart2.Value = member.assignedShifts[1].startTime;
                dtpEnd2.Value = member.assignedShifts[1].endTime;

                dtpStart3.Value = member.assignedShifts[2].startTime;
                dtpEnd3.Value = member.assignedShifts[2].endTime;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpEnd1.Value > dtpStart1.Value &&
                dtpEnd2.Value > dtpStart2.Value &&
                dtpEnd3.Value > dtpStart3.Value)
            {
                Shift[] shifts = { new Shift(dtpStart1.Value, dtpEnd1.Value),
                                 new Shift(dtpStart2.Value, dtpEnd2.Value),
                                 new Shift(dtpStart3.Value, dtpEnd3.Value)};

                int errorCode = _controller.AssignShift(member, shifts);

                if (errorCode == 0)
                {
                    member.assignedShifts.Clear();

                    foreach (Shift shift in shifts)
                    {
                        member.assignedShifts.Add(shift);
                    }

                    Close();
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShiftAddEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.ClosedShiftForm();
        }
    }
}
