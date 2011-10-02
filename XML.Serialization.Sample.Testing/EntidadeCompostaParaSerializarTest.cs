using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using NUnit.Framework;
using XML.Serialziation.Sample;

namespace XML.Serialization.Sample.Testing
{
	[TestFixture()]
	public class EntidadeCompostaParaSerializarTest
	{
		[Test()]
		public void ShouldNotSerializeFieldsFromSuperClass()
		{
			var paraSerializar = new EntidadeCompostaParaSerializar
			{ 
				Description = "Class nova",
				Type = "Qualquer um",
				Attributes = new List<String> { "element_01", "element_02" },
				PropertyFromSuperWithAttribut = "withAttr",
				PropertyFromSuperWithNoAttribut = "withNO"
			};
			
			String XmlizedString = null;
			var memoryStream = new MemoryStream ();
			var xs = new XmlSerializer (typeof(EntidadeCompostaParaSerializar));
			XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream,Encoding.UTF8);
			xs.Serialize (xmlTextWriter, paraSerializar);
			memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
			UTF8Encoding encoding = new UTF8Encoding();
  			XmlizedString = encoding.GetString(memoryStream.ToArray());
			
			Console.Out.WriteLine(XmlizedString);
		}
	}
}

