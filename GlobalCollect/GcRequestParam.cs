using System;
using System.Net;

namespace GlobalCollect
{
    /// <summary>
    /// GC request query parameter setting
    /// </summary>
    public class GcRequestParam
    {
        /// <summary>
        /// the request query name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// the request query value
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// the constructor
        /// </summary>
        /// <param name="name">the request query name</param>
        /// <param name="value">the request query value</param>
        public GcRequestParam(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
            Value = value;
        }

        /// <summary>
        /// convert request query parameter setting to string
        /// </summary>
        /// <returns>the string value</returns>
        public override string ToString()
        {
            return Name + "=" + WebUtility.UrlEncode(Value);
        }
    }
}