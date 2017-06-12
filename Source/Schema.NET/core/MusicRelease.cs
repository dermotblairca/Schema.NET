namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    [DataContract]
    public partial class MusicRelease : MusicPlaylist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRelease";

        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        [DataMember(Name = "catalogNumber", Order = 2)]
        public string CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [DataMember(Name = "creditedTo", Order = 3)]
        public object CreditedTo { get; protected set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [IgnoreDataMember]
        public Person CreditedToPerson
        {
            get => this.CreditedTo as Person;
            set => this.CreditedTo = value;
        }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [IgnoreDataMember]
        public Organization CreditedToOrganization
        {
            get => this.CreditedTo as Organization;
            set => this.CreditedTo = value;
        }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 4)]
        public Duration Duration { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        [DataMember(Name = "musicReleaseFormat", Order = 5)]
        public MusicReleaseFormatType? MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        [DataMember(Name = "recordLabel", Order = 6)]
        public Organization RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        [DataMember(Name = "releaseOf", Order = 7)]
        public MusicAlbum ReleaseOf { get; set; }
    }
}
