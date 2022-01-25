
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace lab3
{
	[TestFixture]

	public class Tests
    {
		[Test]
		public void MoreTest()
		{
			Assert.IsTrue(new SemVersion("1.1.0") > new SemVersion("1.0.0"));
		}

		[Test]
		public void LessTest()
		{
			Assert.IsTrue(new SemVersion("1.0.0") < new SemVersion("1.1.0"));
		}

		[Test]
		public void MoreOrEqualTest()
		{
			Assert.IsTrue(new SemVersion("1.1.0") >= new SemVersion("1.0.0"));
			Assert.IsTrue(new SemVersion("1.0.0") >= new SemVersion("1.0.0"));
		}

		[Test]
		public void LessOrEqualTest()
		{
			Assert.IsTrue(new SemVersion("1.0.0") <= new SemVersion("1.1.0"));
			Assert.IsTrue(new SemVersion("1.0.0") <= new SemVersion("1.0.0"));
		}

		[Test]
		public void EqualTest()
		{
			Assert.IsTrue(new SemVersion("1.0.0") == new SemVersion("1.0.0"));
			Assert.IsTrue(new SemVersion("1.1.0") == new SemVersion("1.1.0"));
		}

		[Test]
		public void NoEqualTest()
		{
			Assert.IsTrue(new SemVersion("1.0.0") != new SemVersion("1.1.0"));
			Assert.IsTrue(new SemVersion("1.1.0") != new SemVersion("1.0.0"));
		}
	}
}
