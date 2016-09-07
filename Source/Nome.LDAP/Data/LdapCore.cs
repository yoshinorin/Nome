/// <summary>
/// Data store class for LDAP.
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
        /// facsimileTelephoneNumber
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// gn
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// l
        /// </summary>
        public string LocalityName { get; set; }

        /// <summary>
        /// o
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// ou
        /// </summary>
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// postalCode
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// st
        /// </summary>
        public string StateOrProvinveName { get; set; }

        /// <summary>
        /// st
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// surName
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
    postalAddress
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
    initials
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
