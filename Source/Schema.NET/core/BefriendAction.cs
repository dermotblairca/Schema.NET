namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically...
    /// </summary>
    [DataContract]
    public partial class BefriendAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BefriendAction";
    }
}
