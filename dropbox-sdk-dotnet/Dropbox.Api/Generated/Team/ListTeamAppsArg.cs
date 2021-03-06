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
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync"
    /// />.</para>
    /// </summary>
    public class ListTeamAppsArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListTeamAppsArg> Encoder = new ListTeamAppsArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListTeamAppsArg> Decoder = new ListTeamAppsArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListTeamAppsArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">At the first call to the <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync" />
        /// the cursor shouldn't be passed. Then, if the result of the call includes a cursor,
        /// the following requests should include the received cursors in order to receive the
        /// next sub list of the team applications.</param>
        public ListTeamAppsArg(string cursor = null)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListTeamAppsArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListTeamAppsArg()
        {
        }

        /// <summary>
        /// <para>At the first call to the <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.LinkedAppsListTeamLinkedAppsAsync" />
        /// the cursor shouldn't be passed. Then, if the result of the call includes a cursor,
        /// the following requests should include the received cursors in order to receive the
        /// next sub list of the team applications.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListTeamAppsArg" />.</para>
        /// </summary>
        private class ListTeamAppsArgEncoder : enc.StructEncoder<ListTeamAppsArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListTeamAppsArg value, enc.IJsonWriter writer)
            {
                if (value.Cursor != null)
                {
                    WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListTeamAppsArg" />.</para>
        /// </summary>
        private class ListTeamAppsArgDecoder : enc.StructDecoder<ListTeamAppsArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListTeamAppsArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListTeamAppsArg Create()
            {
                return new ListTeamAppsArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListTeamAppsArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
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
