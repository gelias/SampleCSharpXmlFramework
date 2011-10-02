using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML.Serialziation.Sample
{
	[XmlRootAttribute(ElementName="Entidade")]
	public class EntidadeCompostaParaSerializar : EntidadeSuper
	{
		[XmlElement(ElementName="description")]
		public String Description {get;set;}
		[XmlIgnore]
		public String Type {get;set;}
		[XmlIgnore]
		public ICollection<String> Attributes {get;set;}
		
		public void save()
		{
			var v1 = "oia";
			
		}
		
	}
}

