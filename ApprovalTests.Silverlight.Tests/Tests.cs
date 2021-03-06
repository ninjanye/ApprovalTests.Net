﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Silverlight.Testing;

namespace ApprovalTests.Silverlight.Tests
{
	[TestClass]
	public class Tests : SilverlightTest
	{
		[TestMethod, Asynchronous]
		public void TestMethod1()
		{
			var control = new TestSilverlightControl();

			TestHelper.WaitFor(this, control, "Loaded");
			TestPanel.Children.Add(control);
			Action action = () => Approvals.Approve(
				@"D:\Projects\ApprovalsForSilverlight\ApprovalTests.Silverlight.Tests",
				"Tests.TestMethod1",
				control);
			EnqueueCallback(action);

			EnqueueTestComplete();
		}
	}
}