using System;

namespace GlobalCollect
{
    /// <summary>
    /// GC request header setting
    /// </summary>
    public class GcRequestHeader
    {        
        /// <summary>
        /// the header name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// the header value
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// the constructor
        /// </summary>
        /// <param name="name">the header name</param>
        /// <param name="value">the header value</param>
        public GcRequestHeader(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
            Value = value;
        }

        /// <summary>
        /// convert the header setting to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + ":" + Value;
        }
    }
}