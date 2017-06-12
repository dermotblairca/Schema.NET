namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e...
    /// </summary>
    [DataContract]
    public partial class ResumeAction : ControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ResumeAction";
    }
}
