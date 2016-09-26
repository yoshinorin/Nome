namespace Nome.Viewer.Services
{
    public class LanguageService
    {
        #region "View"

        #region "Settings"

        public static string Settings { get { return App.Language.View.Settings.Title; } }

        #region "Language"

        public static string Language { get { return App.Language.View.Language.Title; } }

        public static string LanguageDescription { get { return App.Language.View.Language.Description; } }

        #endregion

        #region "UI"

        public static string UI { get { return App.Language.View.UI.Title; } }

        #endregion

        #region "Connection"

        public static string Connection { get { return App.Language.View.Connection.Title; } }

        public static string ConnectionDescription { get { return App.Language.View.Connection.Description; } }

        public static string Destination { get { return App.Language.View.Connection.Destination; } }

        #endregion

        #region "Search"

        public static string Search { get { return App.Language.View.Search.Title; } }

        public static string SearchDescription { get { return App.Language.View.Search.Description; } }

        public static string AddCondition { get { return App.Language.View.Search.AddCondition; } }

        public static string Target { get { return App.Language.View.Search.Target; } }

        public static string Word { get { return App.Language.View.Search.Word; } }

        public static string Condition { get { return App.Language.View.Search.Condition; } }

        #endregion

        #endregion

        #region "Others"

        public static string Others { get { return App.Language.View.Others.Title; } }

        #endregion

        #endregion

        #region "About"

        public static string About { get { return App.Language.View.About.Title; } }

        #endregion

    }
}
