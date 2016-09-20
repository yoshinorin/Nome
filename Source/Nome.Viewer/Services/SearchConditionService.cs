namespace Nome.Viewer.Services
{
    public static class SearchConditionService
    {
        /// <summary>
        /// Get names of <see cref="SearchConditionEnum"> by language.
        /// </summary>
        /// <param name="objectClassEnum"><see cref="SearchConditionEnum"></param>
        /// <returns>Converted Value by language.</returns>
        /// TODO : Can change language of return value using by setting file.
        public static string NameByLanguage(this SearchConditionEnum searchConditionEnum)
        {
            //Currently japanese only.
            string[] names = { "一致", "前方一致", "後方一致", "含む" };
            return names[(int)searchConditionEnum];
        }
    }
}
