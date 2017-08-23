// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed the account capture policy on a domain belonging to the team.</para>
    /// </summary>
    public class AccountCaptureChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccountCaptureChangePolicyDetails> Encoder = new AccountCaptureChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccountCaptureChangePolicyDetails> Decoder = new AccountCaptureChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New account capture policy.</param>
        /// <param name="previousValue">Previous account capture policy. Might be missing due
        /// to historical data gap.</param>
        public AccountCaptureChangePolicyDetails(AccountCapturePolicy newValue,
                                                 AccountCapturePolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AccountCaptureChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New account capture policy.</para>
        /// </summary>
        public AccountCapturePolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous account capture policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public AccountCapturePolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AccountCaptureChangePolicyDetails" />.</para>
        /// </summary>
        private class AccountCaptureChangePolicyDetailsEncoder : enc.StructEncoder<AccountCaptureChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccountCaptureChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.AccountCapturePolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.AccountCapturePolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AccountCaptureChangePolicyDetails" />.</para>
        /// </summary>
        private class AccountCaptureChangePolicyDetailsDecoder : enc.StructDecoder<AccountCaptureChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="AccountCaptureChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccountCaptureChangePolicyDetails Create()
            {
                return new AccountCaptureChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AccountCaptureChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.AccountCapturePolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.AccountCapturePolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}