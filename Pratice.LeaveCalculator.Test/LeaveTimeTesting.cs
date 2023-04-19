using Pratice_LeaveCalculator;
using System;

namespace Pratice.LeaveCalculator.Test
{
	public class Tests
	{
		[SetUp]
		public void Setup ()
		{
		}

		[Test]
		public void TestLeaveTime1()
		{
			var leaveTime = new LeaveTime("10", "14");
			Assert.AreEqual(10, leaveTime.LeaveTimeStart.Hour);
			Assert.AreEqual(14, leaveTime.LeaveTimeEnd.Hour);
			Assert.IsTrue(string.IsNullOrEmpty(leaveTime.ErrorMessage));
		}


		[Test]
		public void TestLeaveTime2()
		{
			var leaveTime = new LeaveTime("9", "14");
			Assert.AreEqual(9, leaveTime.LeaveTimeStart.Hour);
			Assert.AreEqual(14, leaveTime.LeaveTimeEnd.Hour);
		}

		[Test]
		public void TestLeaveTime3 ()
		{
			var leaveTime = new LeaveTime("3", "20");
			Assert.AreEqual(9,leaveTime.LeaveTimeStart.Hour);
			Assert.AreEqual(18, leaveTime.LeaveTimeEnd.Hour);

		}

		[Test]
		public void TestLeaveTime4 ()
		{
			var leaveTime = new LeaveTime("1", "23");
			Assert.AreEqual(9, leaveTime.LeaveTimeStart.Hour);
			Assert.AreEqual(18, leaveTime.LeaveTimeEnd.Hour);
		}

		[Test]
		public void TestLeaveTimeCalc1 ()
		{
			var leaveTime = new LeaveTime("9", "12");
			int result = leaveTime.CalculateLeaveHours();
			Assert.AreEqual(3, result);
		}

		[Test]
		public void TestLeaveTimeCalc2 ()
		{
			var leaveTime = new LeaveTime("9", "14");
			int result = leaveTime.CalculateLeaveHours();
			Assert.AreEqual(4, result);
		}

		[Test]
		public void TestLeaveTimeCalc3 ()
		{
			var leaveTime = new LeaveTime("14", "19");
			int result = leaveTime.CalculateLeaveHours();
			Assert.AreEqual(4, result);
		}

		public void TestLeaveTimeCalc5 ()
		{
			var leaveTime = new LeaveTime("1", "23");
			int result = leaveTime.CalculateLeaveHours();
			Assert.AreEqual(8, result);
		}
	}
}