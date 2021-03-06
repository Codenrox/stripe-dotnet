namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class UsageRecordSummaryServiceTest : BaseStripeTest
    {
        private const string SubscriptionItemId = "si_123";
        private readonly UsageRecordSummaryService service;
        private readonly UsageRecordSummaryListOptions listOptions;

        public UsageRecordSummaryServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new UsageRecordSummaryService();

            this.listOptions = new UsageRecordSummaryListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void List()
        {
            var summaries = this.service.List(SubscriptionItemId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items/si_123/usage_record_summaries");
            Assert.NotNull(summaries);
            Assert.Equal("list", summaries.Object);
            Assert.Single(summaries.Data);
            Assert.Equal("usage_record_summary", summaries.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var summaries = await this.service.ListAsync(SubscriptionItemId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items/si_123/usage_record_summaries");
            Assert.NotNull(summaries);
            Assert.Equal("list", summaries.Object);
            Assert.Single(summaries.Data);
            Assert.Equal("usage_record_summary", summaries.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var summaries = this.service.ListAutoPaging(SubscriptionItemId, this.listOptions).ToList();
            Assert.NotNull(summaries);
            Assert.Equal("usage_record_summary", summaries[0].Object);
        }
    }
}
