using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML.Serialziation.Sample
{

	[XmlRootAttribute(ElementName="Entidade")]
	public class EntidadeParaSerializar
	{
		[XmlElement(ElementName="description")]
		public String Description {get;set;}
		[XmlIgnore]
		public String Type {get;set;}
		[XmlIgnore]
		public ICollection<String> Attributes {get;set;}
		
		public EntidadeParaSerializar ()
		{
		}
	}
}

