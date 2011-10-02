using System;
using System.Xml.Serialization;

namespace XML.Serialziation.Sample
{
	public class EntidadeSuper
	{
		[XmlElement(ElementName="propertyFromSuperWithAttribut")]
		public string PropertyFromSuperWithAttribut{get;set;}
		public string PropertyFromSuperWithNoAttribut{get;set;}
	}
}

