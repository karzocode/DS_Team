using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class SeatSelection : Form
    {
        // TODO (Task 04): Add 2D seat map, UndoStack<Seat>, and constructors here.

        public SeatSelection()
        {
            InitializeComponent();
        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {
            // TODO (Task 04): Generate seat buttons and update summary label.
        }

        private void picUndo_Click(object sender, EventArgs e)
        {
            // TODO (Task 04): Undo last selected seat using UndoStack.
        }

        private void picCheckout_Click(object sender, EventArgs e)
        {
            // TODO (Task 04): Validate selection and open MyBookingForm.
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            // TODO (Task 04): Close SeatSelection.
        }

        // TODO (Task 04): Add helper methods here (e.g., GenerateSeats, Seat_Click, UpdateSummaryLabel).
    }
}
