namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    [DataContract]
    public partial class Invoice : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Invoice";

        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        [DataMember(Name = "accountId", Order = 2)]
        public string AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        [DataMember(Name = "billingPeriod", Order = 3)]
        public Duration BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 4)]
        public object Broker { get; protected set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [IgnoreDataMember]
        public Organization BrokerOrganization
        {
            get => this.Broker as Organization;
            set => this.Broker = value;
        }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [IgnoreDataMember]
        public Person BrokerPerson
        {
            get => this.Broker as Person;
            set => this.Broker = value;
        }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 5)]
        public object Category { get; protected set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public Thing CategoryThing
        {
            get => this.Category as Thing;
            set => this.Category = value;
        }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public string CategoryText
        {
            get => this.Category as string;
            set => this.Category = value;
        }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 6)]
        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 7)]
        public object Customer { get; protected set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [IgnoreDataMember]
        public Person CustomerPerson
        {
            get => this.Customer as Person;
            set => this.Customer = value;
        }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [IgnoreDataMember]
        public Organization CustomerOrganization
        {
            get => this.Customer as Organization;
            set => this.Customer = value;
        }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [DataMember(Name = "minimumPaymentDue", Order = 8)]
        public object MinimumPaymentDue { get; protected set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [IgnoreDataMember]
        public MonetaryAmount MinimumPaymentDueMonetaryAmount
        {
            get => this.MinimumPaymentDue as MonetaryAmount;
            set => this.MinimumPaymentDue = value;
        }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [IgnoreDataMember]
        public PriceSpecification MinimumPaymentDuePriceSpecification
        {
            get => this.MinimumPaymentDue as PriceSpecification;
            set => this.MinimumPaymentDue = value;
        }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 9)]
        public DateTimeOffset? PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 10)]
        public PaymentMethod? PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 11)]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [DataMember(Name = "paymentStatus", Order = 12)]
        public object PaymentStatus { get; protected set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [IgnoreDataMember]
        public PaymentStatusType? PaymentStatusPaymentStatusType
        {
            get => this.PaymentStatus as PaymentStatusType?;
            set => this.PaymentStatus = value;
        }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [IgnoreDataMember]
        public string PaymentStatusText
        {
            get => this.PaymentStatus as string;
            set => this.PaymentStatus = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 13)]
        public object Provider { get; protected set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Organization ProviderOrganization
        {
            get => this.Provider as Organization;
            set => this.Provider = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Person ProviderPerson
        {
            get => this.Provider as Person;
            set => this.Provider = value;
        }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [DataMember(Name = "referencesOrder", Order = 14)]
        public Order ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        [DataMember(Name = "scheduledPaymentDate", Order = 15)]
        public DateTimeOffset? ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [DataMember(Name = "totalPaymentDue", Order = 16)]
        public object TotalPaymentDue { get; protected set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [IgnoreDataMember]
        public PriceSpecification TotalPaymentDuePriceSpecification
        {
            get => this.TotalPaymentDue as PriceSpecification;
            set => this.TotalPaymentDue = value;
        }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [IgnoreDataMember]
        public MonetaryAmount TotalPaymentDueMonetaryAmount
        {
            get => this.TotalPaymentDue as MonetaryAmount;
            set => this.TotalPaymentDue = value;
        }
    }
}
