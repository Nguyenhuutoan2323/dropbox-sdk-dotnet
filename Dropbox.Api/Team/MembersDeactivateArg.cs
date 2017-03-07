// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Exactly one of team_member_id, email, or external_id must be provided to identify
    /// the user account.</para>
    /// </summary>
    /// <seealso cref="MembersRemoveArg" />
    public class MembersDeactivateArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersDeactivateArg> Encoder = new MembersDeactivateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersDeactivateArg> Decoder = new MembersDeactivateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersDeactivateArg" />
        /// class.</para>
        /// </summary>
        /// <param name="user">Identity of user to remove/suspend.</param>
        /// <param name="wipeData">If provided, controls if the user's data will be deleted on
        /// their linked devices.</param>
        public MembersDeactivateArg(UserSelectorArg user,
                                    bool wipeData = true)
        {
            if (user == null)
            {
                throw new sys.ArgumentNullException("user");
            }

            this.User = user;
            this.WipeData = wipeData;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersDeactivateArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MembersDeactivateArg()
        {
            this.WipeData = true;
        }

        /// <summary>
        /// <para>Identity of user to remove/suspend.</para>
        /// </summary>
        public UserSelectorArg User { get; protected set; }

        /// <summary>
        /// <para>If provided, controls if the user's data will be deleted on their linked
        /// devices.</para>
        /// </summary>
        public bool WipeData { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembersDeactivateArg" />.</para>
        /// </summary>
        private class MembersDeactivateArgEncoder : enc.StructEncoder<MembersDeactivateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersDeactivateArg value, enc.IJsonWriter writer)
            {
                WriteProperty("user", value.User, writer, Dropbox.Api.Team.UserSelectorArg.Encoder);
                WriteProperty("wipe_data", value.WipeData, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembersDeactivateArg" />.</para>
        /// </summary>
        private class MembersDeactivateArgDecoder : enc.StructDecoder<MembersDeactivateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersDeactivateArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersDeactivateArg Create()
            {
                return new MembersDeactivateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MembersDeactivateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "user":
                        value.User = Dropbox.Api.Team.UserSelectorArg.Decoder.Decode(reader);
                        break;
                    case "wipe_data":
                        value.WipeData = enc.BooleanDecoder.Instance.Decode(reader);
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