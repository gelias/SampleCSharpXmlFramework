using System;
using System.Collections.Generic;
namespace XML.Serialization
{
	public class EntidadeParaSerializar
	{
		public String Description {get;set;}
		public String Type {get;set;}
		public ICollection<String> Attributes {get;set;}
		
		public EntidadeParaSerializar ()
		{
		}
	}
}

