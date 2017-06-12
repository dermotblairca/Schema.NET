namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// </summary>
    [DataContract]
    public partial class CreativeWorkSeason : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkSeason";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 2)]
        public Person Actor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 3)]
        public Person Director { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 4)]
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 5)]
        public Episode Episode { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 6)]
        public int? NumberOfEpisodes { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 7)]
        public CreativeWorkSeries PartOfSeries { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 8)]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// Position of the season within an ordered group of seasons.
        /// </summary>
        [DataMember(Name = "seasonNumber", Order = 9)]
        public object SeasonNumber { get; protected set; }

        /// <summary>
        /// Position of the season within an ordered group of seasons.
        /// </summary>
        [IgnoreDataMember]
        public string SeasonNumberText
        {
            get => this.SeasonNumber as string;
            set => this.SeasonNumber = value;
        }

        /// <summary>
        /// Position of the season within an ordered group of seasons.
        /// </summary>
        [IgnoreDataMember]
        public int? SeasonNumberInteger
        {
            get => this.SeasonNumber as int?;
            set => this.SeasonNumber = value;
        }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 10)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 11)]
        public VideoObject Trailer { get; set; }
    }
}
