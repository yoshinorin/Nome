/// <summary>
/// Provide language services for views.
/// </summary>
namespace Nome.Viewer.Services.Language.Views
{
    public static class Settings
    {
        public static string Title { get { return App.Language.View.Settings.Title; } }
    }

    public static class Language
    {
        public static string Title { get { return App.Language.View.Language.Title; } }

        public static string Description { get { return App.Language.View.Language.Description; } }
    }

    public static class UI
    {
        public static string Title { get { return App.Language.View.UI.Title; } }
    }

    public static class Connection
    {
        public static string Title { get { return App.Language.View.Connection.Title; } }

        public static string Description { get { return App.Language.View.Connection.Description; } }

        public static string Destination { get { return App.Language.View.Connection.Destination; } }
    }

    public static class Search
    {
        public static string Title { get { return App.Language.View.Search.Title; } }

        public static string Description { get { return App.Language.View.Search.Description; } }

        public static string AddCondition { get { return App.Language.View.Search.AddCondition; } }

        public static string Target { get { return App.Language.View.Search.Target; } }

        public static string Word { get { return App.Language.View.Search.Word; } }

        public static string Condition { get { return App.Language.View.Search.Condition; } }
    }

    public static class Others
    {
        public static string Title { get { return App.Language.View.Others.Title; } }
    }

    public static class About
    {
        public static string Title { get { return App.Language.View.About.Title; } }
    }
}
