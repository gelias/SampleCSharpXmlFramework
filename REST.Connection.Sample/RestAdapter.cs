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
			HttpWebResponse response = null;
			try{
				HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
				request.AllowAutoRedirect = false;
				response = (HttpWebResponse)request.GetResponse();
			}
			catch(WebException we)
			{
				 response = ((HttpWebResponse)we.Response);
			}
			StreamReader reader = new StreamReader(response.GetResponseStream());  
			responseAsString = reader.ReadToEnd();
			return responseAsString;
		}
	}
}

