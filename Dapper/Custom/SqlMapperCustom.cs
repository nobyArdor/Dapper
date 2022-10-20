﻿#nullable enable
using System;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Dapper
{
    /// <summary>
    /// Custom options for Dapper in Akara team
    /// </summary>
    public static class SqlMapperCustom
    {

        //fix for https://elegantcode.com/2012/08/23/net-4-5-operation-could-destabilize-the-runtime-yikes/
        internal static MethodInfo? EnumParseMethod;

        //https://github.com/StackExchange/Dapper/issues/694
        /// <summary>
        /// Only static method allowed
        /// </summary>
        public static Func<Type, string, bool, object>? EnumParse
        {
            set => EnumParseMethod = value?.Method;
        }

        /// <summary>
        /// function for additional lookup DbType
        /// </summary>
        public static Func<PropertyInfo, DbType?>? ExternalLookupDbType { get; set; }

        /// <summary>
        /// Regex for find params like Ole
        /// </summary>
        /// <example>
        /// Regex(@"(?&lt;![\p{L}\p{N}@_])[?@:](?![\p{L}\p{N}@_:])", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.Compiled)
        /// </example>
        public static Regex? SmellsLikeOleDb { internal get; set; }
    }
}
#nullable restore
