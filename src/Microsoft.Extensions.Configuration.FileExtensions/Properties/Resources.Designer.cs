// <auto-generated />
namespace Microsoft.Extensions.Configuration.FileExtensions
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Extensions.Configuration.FileExtensions.Resources", typeof(Resources).Assembly);

        /// <summary>
        /// The configuration file '{0}' was not found and is not optional.
        /// </summary>
        internal static string Error_FileNotFound
        {
            get { return GetString("Error_FileNotFound"); }
        }

        /// <summary>
        /// The configuration file '{0}' was not found and is not optional.
        /// </summary>
        internal static string FormatError_FileNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FileNotFound"), p0);
        }

        /// <summary>
        /// The expected physical path was '{0}'.
        /// </summary>
        internal static string Error_ExpectedPhysicalPath
        {
            get { return GetString("Error_FileNotFound"); }
        }

        /// <summary>
        /// The expected physical path was '{0}'.
        /// </summary>
        internal static string FormatError_ExpectedPhysicalPath(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_ExpectedPhysicalPath"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
