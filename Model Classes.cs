public class Customer
    {
         
        public string CustomerID { get; set; }

         
        public string CustomerName { get; set; }

         
        public string Salutation { get; set; }

		//Added for testing git purpose
         
        public string FirstName { get; set; }

         
        public string MiddleName { get; set; }

         
        public string LastName { get; set; }

         
        public string WebsiteURL { get; set; }

         
        public string AccountStatus { get; set; }

         
        public string LegalEntityType { get; set; }

       
         
        public List<Documents> Documents { get; set; }

        // 
        //public LegalIdentification LegalIdentification { get; set; }

         
        public OrganizationDetails OrganizationDetails { get; set; }

         
        public PersonDetails PersonDetails { get; set;}

         
        public ProductServices ProductServices { get; set; }

         
        public ContactPreferences ContactPreferences { get; set; }

         
       // public List<RiskLocations> RiskLocations { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public CustomerRegistration CustomerRegistration { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public CustomerDemographics CustomerDemographics { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public RelativeAssociations RelativeAssociations { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public Interactions Interactions { get; set; }

        public string CreatedBy {get;set;}
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }


    }
	
	 public class PersonDetails
    {
        
        public string ConsumerSinceDate { get; set; }
	}
	
	 public class OrganizationDetails
    {
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string DUNSNumber { get; set; }

         
        public int? NumberOfEmployees { get; set; }

         
        public string BusinessName { get; set; }

         
        public decimal? AnnualRevenue { get; set; }

         
        public string IndustryType { get; set; }

         
        public string SubIndustryType { get; set; }

         
        public string SIC { get; set; }

         
        public string NAICSCode { get; set; }
    }
	
	public class ContactAndPreferences
    {
       
        public List<Address> Address { get; set; }

       
        public List<Email> Email { get; set; }

        
        public List<Phone> Phone { get; set; }

        
    }
	
	public class Email
    {
        
        public string EmailType { get; set; }

       
        public string EmailAddress { get; set; }

        public string IsPreferredEmail { get; set; }
    }
	
	 public class Phone
    {
        
        public string PhoneId { get; set; }

        
        public string PhoneType { get; set; }

        
        public string PhoneNum { get; set; }

       
        public string PhoneExt { get; set; }

        
        public string IsPreferredNumber { get; set; }

        
    }
	
	public class Address
    {
         
        public string AddressId { get; set; }

         
        public string AddressType { get; set; }

         
        //public string PrimaryContactName { get; set; }

         
        public string AddressLine1 { get; set; }

         
        public string AddressLine2 { get; set; }

         
        public string AddressLine3 { get; set; }

         
        public string City { get; set; }

         
        public string County { get; set; }

         
        public string Zipcode { get; set; }

         
        public string State { get; set; }

         
        public string Country { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string POBoxNumber { get; set; }

         
        public string IsPreferredAddress { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string UTCTimeZone { get; set; }

         
        public decimal? Latitude { get; set; }

         
       // public decimal? Longitude { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string UPSZone { get; set; }

    }
	
	
	public class Documents
    {                
         
        public string DocumentId { get; set; }

         
        public string DocumentType { get; set; }

         
        public string DocumentName { get; set; }

         
        public string TransactionType { get; set; }
        //public string AgentId { get; set; }
        //public string AgentAccountName { get; set; }
        public string MediaLocation { get; set; }
        //public string Content { get; set; }
        public string DocumentContent { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string UploadedOn { get; set; }
    }
	
	public class ProductAndServices
    {
        public decimal? TotalPremium { get; set; }
       
     

        public List<Billing> Billing { get; set; }
      
        public List<Claim> Claim { get; set; }
        
        public List<Policy> Policy { get; set; }

        public List<Policy> Quote { get; set; }

        
       
    }
	
	public class Billing
    {
         
        public string BillNumber { get; set; }

         
        public string BillId { get; set; }

         
        public string PolicyNumber { get; set; }

       

         
        public DateTime PaymentDueDate { get; set; }

		 public List<Agent> Agent { get; set; }

         
        public string AgencyName { get; set; }

        
         
        public string AgentName { get; set; }

         
        public decimal? MinimumAmountDue { get; set; }

         
        public decimal? TotalAmountDue { get; set; }

         
        public string BillStatus { get; set; }


        public string InstallmentNumber { get; set; }
        public string InstallmentEffectiveDate { get; set; }
        public string OutsandingAmount { get; set; }
        public string DueDate { get; set; }
        public string PaymentStatus { get; set; }
        public string AgentCode { get; set; }
        public string AgencyCode { get; set; }
        public string TransactionType { get; set; }
        public decimal? InstallementAmount { get; set; }
       
        public string UpcomingBillDate { get; set; }
            
    }
	
	public class Claim
    {

		public List<Agent> Agent { get; set; }
       
        public decimal? AdjusterAmount { get; set; }

         
        public DateTime DateOfLoss { get; set; }

         
        public string ClaimNumber { get; set; }

         
        public string PolicyNumber { get; set; }

         
        public List<Product> Product { get; set; }

         
        public string Description { get; set; }

         
        public string ClaimantName { get; set; }

         
        public decimal? EstimatedLossAmount { get; set; }

        
         
        public DateTime ReportedDate { get; set; }

         
        public DateTime DateClosed { get; set; }

        public string ClaimId { get; set; }
        public int? TotalClaims { get; set; }
        public string ClaimStatus { get; set; }
        
        public string AgentCode { get; set; }
        public string AgentName { get; set; }
       
        public string AgencyCode { get; set; }
        public string AgencyName { get; set; }
        public string AdjusterName { get; set; }
        public string Program { get; set; }
      

    }
	public class Agent
    {
       

        public string AgentCode { get; set; }
        public string AgentName { get; set; }
       
        public string AgencyCode { get; set; }
        public string AgencyName { get; set; }

       
    }
	
	 public class Policy
    {
        public DateTime BusinessInceptionYear { get; set; }
        
        public string DoingBusinessAs { get; set; }
        public string PolicyId { get; set; }
        public string PolicyNumber { get; set; }        
        public decimal? Premium { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpiryDate { get; set; }
        public string PolicyStatus { get; set; }
        public string DescriptionOfOperations { get; set; }
        public string IndustryType { get; set; }
        public string SubIndustryType { get; set; }
        public string TransactionType { get; set; }

        public string Program { get; set; }

        public string QuoteNumber { get; set; }
        public string QuoteId { get; set; }
        public string QuoteStatus { get; set; }


		public List<Agent> Agent { get; set; }
        public List<Product> Product { get; set; }
        public List<CarrierDetails> CarrierDetails { get; set; }
       

        //public Customer Customer { get; set; }
       
        public List<RiskLocations> RiskLocations { get; set; }
       
        
        
    
    }
	
	
	  public class Product
    {
        public string ProductName { get; set; }
	}
	
	 public class RiskLocations
    {
        public string LocationId { get; set; }
        public int LocationNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Status { get; set; }
    }
	
	public class CarrierDetails
    {
        public string CarrierName { get; set; }
    }