namespace CommonWell.Tools
{
    public class CommonWellClaimTypes
    {
        /// <summary>
        /// Emr Vendor Name.
        /// </summary>
        public const string EmrVendorName = "http://commonwellalliance.org/claims/EmrVendorName";

        /// <summary>
        /// Emr Vendor Id.
        /// </summary>
        public const string EmrVendorId = "http://commonwellalliance.org/claims/EmrVendorId";

        /// <summary>
        /// RequestDateTimeUtc.
        /// </summary>
        public const string RequestDateTimeUtc = "http://commonwellalliance.org/claims/RequestDateTimeUtc";

        /// <summary>
        /// CorrelationId.
        /// </summary>
        public const string CorrelationId = "http://commonwellalliance.org/claims/CorrelationId";

        /// <summary>
        /// The ID of the initiating organization's facility.
        /// </summary>
        public const string FacilityId = "http://commonwellalliance.org/claims/FacilityId";

        /// <summary>
        /// The name of the initiating organization's facility.
        /// </summary>
        public const string FacilityName = "http://commonwellalliance.org/claims/FacilityName";

        /// <summary>
        /// The source organization that the request is made on behalf of.
        /// </summary>
        public const string BAASource = "http://commonwellalliance.org/claims/baasource";

        /// <summary>
        /// The source insurance organization that the request is made on behalf of.
        /// TODO : Will replace BAA Source
        /// </summary>
        public const string NAICSource = "http://commonwellalliance.org/claims/naicsource";

        /// <summary>
        /// The audit identifier what is used to trace the entire workflow.
        /// </summary>
        public const string AuditRequestId = "http://commonwellalliance.org/claims/auditrequestid";
    }
}