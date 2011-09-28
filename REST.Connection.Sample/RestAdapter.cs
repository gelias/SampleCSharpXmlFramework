using System;
using System.Net;
using System.Text;
using System.IO;

namespace REST.Connection.Sample
{
	public class RestAdapter
	{
		public string connect (string url)
		{
			string responseAsString = string.Empty;
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)  
			{  
			    StreamReader reader = new StreamReader(response.GetResponseStream());  
			    responseAsString = reader.ReadToEnd();
			}  
			return responseAsString;
		}
	}
}

