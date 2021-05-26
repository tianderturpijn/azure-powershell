// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured.
    /// This setting is only needed if multiple providers are configured and the unauthenticated client
    /// action is set to "RedirectToLoginPage".
    /// </summary>
    public partial struct BuiltInAuthenticationProvider :
        System.IEquatable<BuiltInAuthenticationProvider>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider AzureActiveDirectory = @"AzureActiveDirectory";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider Facebook = @"Facebook";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider Google = @"Google";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider MicrosoftAccount = @"MicrosoftAccount";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider Twitter = @"Twitter";

        /// <summary>
        /// the value for an instance of the <see cref="BuiltInAuthenticationProvider" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="BuiltInAuthenticationProvider" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private BuiltInAuthenticationProvider(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to BuiltInAuthenticationProvider</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BuiltInAuthenticationProvider" />.</param>
        internal static object CreateFrom(object value)
        {
            return new BuiltInAuthenticationProvider(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type BuiltInAuthenticationProvider</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type BuiltInAuthenticationProvider (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is BuiltInAuthenticationProvider && Equals((BuiltInAuthenticationProvider)obj);
        }

        /// <summary>Returns hashCode for enum BuiltInAuthenticationProvider</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for BuiltInAuthenticationProvider</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to BuiltInAuthenticationProvider</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BuiltInAuthenticationProvider" />.</param>

        public static implicit operator BuiltInAuthenticationProvider(string value)
        {
            return new BuiltInAuthenticationProvider(value);
        }

        /// <summary>Implicit operator to convert BuiltInAuthenticationProvider to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="BuiltInAuthenticationProvider" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum BuiltInAuthenticationProvider</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum BuiltInAuthenticationProvider</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BuiltInAuthenticationProvider e2)
        {
            return e2.Equals(e1);
        }
    }
}