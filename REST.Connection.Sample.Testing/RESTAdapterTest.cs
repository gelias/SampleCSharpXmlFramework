using System;
using NUnit.Framework;
using REST.Connection.Sample;

namespace REST.Connection.Sample.Testing
{
	[TestFixture]
	public class RESTAdapterTest
	{
		[Test]
		public void shouldConnectSuccessfullyRESTService()
		{
			var adapter = new RestAdapter();
			string response = adapter.connect("https://api.twitter.com/1/statuses/home_timeline.json?");
			Assert.IsTrue(response.Contains("Could not authenticate you"), "Should have html tag");
		}
			
	}
}

