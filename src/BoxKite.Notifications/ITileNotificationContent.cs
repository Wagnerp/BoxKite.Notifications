using System;
using Windows.UI.Notifications;

namespace BoxKite.Notifications
{
    /// <summary>
    /// Base tile notification content interface.
    /// </summary>
    public interface ITileNotificationContent : INotificationContent
    {
        /// <summary>
        /// Whether strict validation should be applied when the Xml or notification object is created,
        /// and when some of the properties are assigned.
        /// </summary>
        bool StrictValidation { get; set; }

        /// <summary>
        /// The language of the content being displayed.  The language should be specified using the
        /// abbreviated language code as defined by BCP 47.
        /// </summary>
        string Lang { get; set; }

        /// <summary>
        /// The BaseUri that should be used for image locations.  Relative image locations use this
        /// field as their base Uri.  The BaseUri must begin with http://, https://, ms-appx:///, or 
        /// ms-appdata:///local/.
        /// </summary>
        string BaseUri { get; set; }

        /// <summary>
        /// Determines the application branding when tile notification content is displayed on the tile.
        /// </summary>
        TileBranding Branding { get; set; }

#if !WINRT_NOT_PRESENT
        /// <summary>
        /// Creates a WinRT TileNotification object based on the content.
        /// </summary>
        /// <returns>The WinRT TileNotification object</returns>
        TileNotification CreateNotification();
#endif
    }
}