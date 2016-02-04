using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace XMLclassBuild
{
    [Serializable]
    class XMLTagIsAlreadyOpen : Exception
    {
        public XMLTagIsAlreadyOpen() : base() { }
        public XMLTagIsAlreadyOpen(string message) : base(message) { }
        public XMLTagIsAlreadyOpen(string message, Exception innerException) : base(message, innerException) { }
        public XMLTagIsAlreadyOpen(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    class ThereAreNoOpenTags : Exception
    {
        public ThereAreNoOpenTags() : base() { }
        public ThereAreNoOpenTags(string message) : base(message) { }
        public ThereAreNoOpenTags(string message, Exception innerException) : base(message, innerException) { }
        public ThereAreNoOpenTags(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
