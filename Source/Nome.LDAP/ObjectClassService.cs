/// <summary>
/// Provide function of LDAP.
/// </summary>
namespace Nome.LDAP
{
    /// <summary>
    /// Provide feature of LDAP Object Class.
    /// </summary>
    public static class ObjectClassService
    {
        /// <summary>
        /// Get names of <see cref="ObjectClassTypeEnum"> by language.
        /// </summary>
        /// <param name="objectClassEnum"><see cref="ObjectClassTypeEnum"></param>
        /// <returns>Converted Value by language.</returns>
        /// TODO : Can change language of return value using by setting file.
        public static string NameByLanguage(this ObjectClassTypeEnum objectClassEnum)
        {
            //Currently japanese only.
            string[] names = { "ユーザー", "コンピューター" };
            return names[(int)objectClassEnum];
        }
    }
}
