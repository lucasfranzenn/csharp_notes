using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XML_Serialization
{
	[DataContract]
    internal class Person
    {
		[DataMember]
		private string? _name;

		[DataMember]
		private uint _age;

        public string? Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public uint Age
		{
			get { return _age; }
			set { _age = value; }
		}

        public Person(string name, uint age)
        {
			_name = name;
			_age = age;
        }

        public Person()
        {
            
        }
    }
}
