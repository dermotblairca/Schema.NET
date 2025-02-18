namespace Schema.NET.Test.Examples;

using System;
using Xunit;

// https://developers.google.com/search/docs/data-types/factcheck
public class ClaimReviewTest
{
    private readonly ClaimReview claimReview = new()
    {
        DatePublished = new DateTime(2016, 6, 22), // Required
        Url = new Uri("https://example.com/news/science/worldisflat.html"), // Required
        ItemReviewed = new CreativeWork() // Required
        {
            Author = new Organization() // Required
            {
                Name = "Square World Society", // Required
                SameAs = new Uri("https://example.flatworlders.com/we-know-that-the-world-is-flat"), // Recommended
            },
            DatePublished = new DateTime(2016, 6, 20), // Optional
        },
        ClaimReviewed = "The world is flat", // Required
        Author = new Organization() // Required
        {
            Name = "Example.com science watch",
        },
        ReviewRating = new Rating() // Required
        {
            RatingValue = 1D, // Required
            BestRating = 5D, // Required
            WorstRating = 1D, // Required
            AlternateName = "False", // Recommended
        },
    };

    private readonly string json =
    "{" +
        "\"@context\":\"https://schema.org\"," +
        "\"@type\":\"ClaimReview\"," +
        "\"url\":\"https://example.com/news/science/worldisflat.html\"," +
        "\"author\":{" +
            "\"@type\":\"Organization\"," +
            "\"name\":\"Example.com science watch\"" +
        "}," +
        "\"datePublished\":\"2016-06-22\"," +
        "\"itemReviewed\":{" +
            "\"@type\":\"CreativeWork\"," +
            "\"author\":{" +
                "\"@type\":\"Organization\"," +
                "\"name\":\"Square World Society\"," +
                "\"sameAs\":\"https://example.flatworlders.com/we-know-that-the-world-is-flat\"" +
            "}," +
            "\"datePublished\":\"2016-06-20\"" +
        "}," +
        "\"reviewRating\":{" +
            "\"@type\":\"Rating\"," +
            "\"alternateName\":\"False\"," +
            "\"bestRating\":5.0," +
            "\"ratingValue\":1.0," +
            "\"worstRating\":1.0" +
        "}," +
        "\"claimReviewed\":\"The world is flat\"" +
    "}";

    [Fact]
    public void Deserializing_ClaimReviewJsonLd_ReturnsClaimReview()
    {
        Assert.Equal(this.claimReview.ToString(), SchemaSerializer.DeserializeObject<ClaimReview>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.claimReview), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<ClaimReview>(this.json)!));
    }
}
