/// <summary>
/// Provide function of LDAP.
/// </summary>
namespace Nome.LDAP.Data
{
    /// <summary>
    /// Store LDAP (OpenLDAP)'s data.
    /// Basically, this class has been implemented with reference to the openldap's core.
    /// But some attribute has not been implemented.
    /// </summary>
    /// TODO:Map LDAP data using by Attribute.
    /// TODO:Consider properties scope.
    /// TODO:Consider properties type.
    public class LdapCore
    {
        /// <summary>
        /// c
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// displayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// employeeNumber
        /// </summary>
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// employeeType
        /// </summary>
        public string EmployeeType { get; set; }

        /// <summary>
        /// facsimileTelephoneNumber
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// gn
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// initials
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// l
        /// </summary>
        public string LocalityName { get; set; }

        /// <summary>
        /// mail
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// mobile
        /// </summary>
        public string Moblie { get; set; }

        /// <summary>
        /// o
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// ou
        /// </summary>
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// postalAddress
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// postalCode
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// st
        /// </summary>
        public string StateOrProvinveName { get; set; }

        /// <summary>
        /// sa
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// sn
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// telephoneNumber
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// title
        /// </summary>
        public string Title { get; set; }
    }

    #region "Not implement attributes"

    /* 
    knowledgeInformation
    serialNumber
    searchGuide
    businessCategory
    postOfficeBox
    physicalDeliveryOfficeName
    telexNumber
    teletexTerminalIdentifier
    internationaliSDNNumber
    registeredAddress
    destinationIndicator
    preferredDeliveryMethod
    presentationAddress
    supportedApplicationContext
    member
    owner
    roleOccupant
    seeAlso
    userPassword
    userCertificate
    cACertificate
    authorityRevocationList
    certificateRevocationList
    crossCertificatePair
    generationQualifier
    x500UniqueIdentifier
    dnQualifier
    enhancedSearchGuide
    protocolInformation
    distinguishedName
    uniqueMember
    houseIdentifier
    supportedAlgorithms
    deltaRevocationList
    dmdName
    pseudonym
    */

    #endregion
}
