using System;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
