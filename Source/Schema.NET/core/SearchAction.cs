namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of searching for an object.
    /// Related actions:
    ///
    /// FindAction: SearchAction generally leads to a FindAction, but not necessarily.
    /// </summary>
    [DataContract]
    public partial class SearchAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchAction";

        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        [DataMember(Name = "query", Order = 2)]
        public string Query { get; set; }
    }
}
