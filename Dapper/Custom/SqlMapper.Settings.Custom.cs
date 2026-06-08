//akara mod
using System;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Dapper
{
    public static partial class SqlMapper
    {
        /// <summary>
        /// Custom options for Dapper in Akara team
        /// </summary>
        public static partial class Settings
        {
            /// <summary>
            /// function for additional lookup DbType
            /// </summary>
            public static Func<PropertyInfo, DbType?>? ExternalLookupDbType { internal get; set; }

            /// <summary>
            /// Regex for find params like Ole
            /// </summary>
            /// <example>
            /// Regex(@"(?&lt;![\p{L}\p{N}@_])[?@:](?![\p{L}\p{N}@_:])", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.Compiled)
            /// </example>
            public static Regex? SmellsLikeOleDb { internal get; set; }
        }
    }
}
#nullable restore
