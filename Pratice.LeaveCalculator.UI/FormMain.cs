using Pratice_LeaveCalculator;

namespace Pratice.LeaveCalculator.UI
{
	public partial class LeaveCalculator : Form
	{
		public LeaveCalculator ()
		{
			InitializeComponent();
		}

		private void LeaveCalculator_Load ( object sender, EventArgs e )
		{
			labelResult.Text = string.Empty;
		}

		private void btnCalc_Click ( object sender, EventArgs e )
		{
			var leavetime = new LeaveTime(textBoxStart.Text, textBoxEnd.Text);

			labelResult.Text =
				( string.IsNullOrEmpty(leavetime.ErrorMessage) )
				? $"¦@{leavetime.CalculateLeaveHours()}¤p®É"
				: leavetime.ErrorMessage;
		}
	}
}