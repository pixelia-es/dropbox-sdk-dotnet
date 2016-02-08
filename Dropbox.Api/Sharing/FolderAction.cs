// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Actions that may be taken on shared folders.</para>
    /// </summary>
    public class FolderAction
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FolderAction> Encoder = new FolderActionEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FolderAction> Decoder = new FolderActionDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderAction" /> class.</para>
        /// </summary>
        public FolderAction()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ChangeOptions</para>
        /// </summary>
        public bool IsChangeOptions
        {
            get
            {
                return this is ChangeOptions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ChangeOptions, or <c>null</c>.</para>
        /// </summary>
        public ChangeOptions AsChangeOptions
        {
            get
            {
                return this as ChangeOptions;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EditContents</para>
        /// </summary>
        public bool IsEditContents
        {
            get
            {
                return this is EditContents;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EditContents, or <c>null</c>.</para>
        /// </summary>
        public EditContents AsEditContents
        {
            get
            {
                return this as EditContents;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unmount</para>
        /// </summary>
        public bool IsUnmount
        {
            get
            {
                return this is Unmount;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unmount, or <c>null</c>.</para>
        /// </summary>
        public Unmount AsUnmount
        {
            get
            {
                return this as Unmount;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unshare</para>
        /// </summary>
        public bool IsUnshare
        {
            get
            {
                return this is Unshare;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unshare, or <c>null</c>.</para>
        /// </summary>
        public Unshare AsUnshare
        {
            get
            {
                return this as Unshare;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FolderAction" />.</para>
        /// </summary>
        private class FolderActionEncoder : enc.StructEncoder<FolderAction>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FolderAction value, enc.IJsonWriter writer)
            {
                if (value is ChangeOptions)
                {
                    WriteProperty(".tag", "change_options", writer, enc.StringEncoder.Instance);
                    ChangeOptions.Encoder.EncodeFields((ChangeOptions)value, writer);
                    return;
                }
                if (value is EditContents)
                {
                    WriteProperty(".tag", "edit_contents", writer, enc.StringEncoder.Instance);
                    EditContents.Encoder.EncodeFields((EditContents)value, writer);
                    return;
                }
                if (value is Unmount)
                {
                    WriteProperty(".tag", "unmount", writer, enc.StringEncoder.Instance);
                    Unmount.Encoder.EncodeFields((Unmount)value, writer);
                    return;
                }
                if (value is Unshare)
                {
                    WriteProperty(".tag", "unshare", writer, enc.StringEncoder.Instance);
                    Unshare.Encoder.EncodeFields((Unshare)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FolderAction" />.</para>
        /// </summary>
        private class FolderActionDecoder : enc.UnionDecoder<FolderAction>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FolderAction" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FolderAction Create()
            {
                return new FolderAction();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override FolderAction Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "change_options":
                        return ChangeOptions.Decoder.DecodeFields(reader);
                    case "edit_contents":
                        return EditContents.Decoder.DecodeFields(reader);
                    case "unmount":
                        return Unmount.Decoder.DecodeFields(reader);
                    case "unshare":
                        return Unshare.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Change folder options, such as who can be invited to join the folder.</para>
        /// </summary>
        public sealed class ChangeOptions : FolderAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ChangeOptions> Encoder = new ChangeOptionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ChangeOptions> Decoder = new ChangeOptionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ChangeOptions" />
            /// class.</para>
            /// </summary>
            private ChangeOptions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ChangeOptions</para>
            /// </summary>
            public static readonly ChangeOptions Instance = new ChangeOptions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ChangeOptions" />.</para>
            /// </summary>
            private class ChangeOptionsEncoder : enc.StructEncoder<ChangeOptions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ChangeOptions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ChangeOptions" />.</para>
            /// </summary>
            private class ChangeOptionsDecoder : enc.StructDecoder<ChangeOptions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ChangeOptions" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ChangeOptions Create()
                {
                    return new ChangeOptions();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ChangeOptions DecodeFields(enc.IJsonReader reader)
                {
                    return ChangeOptions.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Change or edit contents of the folder.</para>
        /// </summary>
        public sealed class EditContents : FolderAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EditContents> Encoder = new EditContentsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EditContents> Decoder = new EditContentsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EditContents" />
            /// class.</para>
            /// </summary>
            private EditContents()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EditContents</para>
            /// </summary>
            public static readonly EditContents Instance = new EditContents();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EditContents" />.</para>
            /// </summary>
            private class EditContentsEncoder : enc.StructEncoder<EditContents>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EditContents value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EditContents" />.</para>
            /// </summary>
            private class EditContentsDecoder : enc.StructDecoder<EditContents>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EditContents" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EditContents Create()
                {
                    return new EditContents();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override EditContents DecodeFields(enc.IJsonReader reader)
                {
                    return EditContents.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Unmount the folder.</para>
        /// </summary>
        public sealed class Unmount : FolderAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unmount> Encoder = new UnmountEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unmount> Decoder = new UnmountDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unmount" /> class.</para>
            /// </summary>
            private Unmount()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unmount</para>
            /// </summary>
            public static readonly Unmount Instance = new Unmount();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unmount" />.</para>
            /// </summary>
            private class UnmountEncoder : enc.StructEncoder<Unmount>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unmount value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unmount" />.</para>
            /// </summary>
            private class UnmountDecoder : enc.StructDecoder<Unmount>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unmount" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unmount Create()
                {
                    return new Unmount();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Unmount DecodeFields(enc.IJsonReader reader)
                {
                    return Unmount.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Stop sharing this folder.</para>
        /// </summary>
        public sealed class Unshare : FolderAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unshare> Encoder = new UnshareEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unshare> Decoder = new UnshareDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unshare" /> class.</para>
            /// </summary>
            private Unshare()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unshare</para>
            /// </summary>
            public static readonly Unshare Instance = new Unshare();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unshare" />.</para>
            /// </summary>
            private class UnshareEncoder : enc.StructEncoder<Unshare>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unshare value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unshare" />.</para>
            /// </summary>
            private class UnshareDecoder : enc.StructDecoder<Unshare>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unshare" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unshare Create()
                {
                    return new Unshare();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Unshare DecodeFields(enc.IJsonReader reader)
                {
                    return Unshare.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : FolderAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}