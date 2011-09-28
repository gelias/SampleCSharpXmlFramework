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
			string response = adapter.connect("http://www.terra.com.br");
			Assert.IsTrue(response.Contains("html"), "Should have html tag");
		}
			
	}
}

