// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Storage Report Result. Each of the items in the storage report is an array of
    /// values, one value per day. If there is no data for a day, then the value will be
    /// None.</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Team.BaseDfbReport" />
    public class GetStorageReport : BaseDfbReport
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetStorageReport> Encoder = new GetStorageReportEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetStorageReport> Decoder = new GetStorageReportDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetStorageReport" />
        /// class.</para>
        /// </summary>
        /// <param name="startDate">First date present in the results as 'YYYY-MM-DD' or
        /// None.</param>
        /// <param name="totalUsage">Sum of the shared, unshared, and datastore usages, for
        /// each day.</param>
        /// <param name="sharedUsage">Array of the combined size (bytes) of team members'
        /// shared folders, for each day.</param>
        /// <param name="unsharedUsage">Array of the combined size (bytes) of team members'
        /// root namespaces, for each day.</param>
        /// <param name="sharedFolders">Array of the number of shared folders owned by team
        /// members, for each day.</param>
        /// <param name="memberStorageMap">Array of storage summaries of team members' account
        /// sizes. Each storage summary is an array of key, value pairs, where each pair
        /// describes a storage bucket. The key indicates the upper bound of the bucket and the
        /// value is the number of users in that bucket. There is one such summary per day. If
        /// there is no data for a day, the storage summary will be empty.</param>
        public GetStorageReport(string startDate,
                                col.IEnumerable<ulong?> totalUsage,
                                col.IEnumerable<ulong?> sharedUsage,
                                col.IEnumerable<ulong?> unsharedUsage,
                                col.IEnumerable<ulong?> sharedFolders,
                                col.IEnumerable<col.IEnumerable<StorageBucket>> memberStorageMap)
            : base(startDate)
        {
            var totalUsageList = enc.Util.ToList(totalUsage);

            if (totalUsage == null)
            {
                throw new sys.ArgumentNullException("totalUsage");
            }

            var sharedUsageList = enc.Util.ToList(sharedUsage);

            if (sharedUsage == null)
            {
                throw new sys.ArgumentNullException("sharedUsage");
            }

            var unsharedUsageList = enc.Util.ToList(unsharedUsage);

            if (unsharedUsage == null)
            {
                throw new sys.ArgumentNullException("unsharedUsage");
            }

            var sharedFoldersList = enc.Util.ToList(sharedFolders);

            if (sharedFolders == null)
            {
                throw new sys.ArgumentNullException("sharedFolders");
            }

            var memberStorageMapList = enc.Util.ToList(memberStorageMap);

            if (memberStorageMap == null)
            {
                throw new sys.ArgumentNullException("memberStorageMap");
            }

            this.TotalUsage = totalUsageList;
            this.SharedUsage = sharedUsageList;
            this.UnsharedUsage = unsharedUsageList;
            this.SharedFolders = sharedFoldersList;
            this.MemberStorageMap = memberStorageMapList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetStorageReport" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetStorageReport()
        {
        }

        /// <summary>
        /// <para>Sum of the shared, unshared, and datastore usages, for each day.</para>
        /// </summary>
        public col.IList<ulong?> TotalUsage { get; protected set; }

        /// <summary>
        /// <para>Array of the combined size (bytes) of team members' shared folders, for each
        /// day.</para>
        /// </summary>
        public col.IList<ulong?> SharedUsage { get; protected set; }

        /// <summary>
        /// <para>Array of the combined size (bytes) of team members' root namespaces, for each
        /// day.</para>
        /// </summary>
        public col.IList<ulong?> UnsharedUsage { get; protected set; }

        /// <summary>
        /// <para>Array of the number of shared folders owned by team members, for each
        /// day.</para>
        /// </summary>
        public col.IList<ulong?> SharedFolders { get; protected set; }

        /// <summary>
        /// <para>Array of storage summaries of team members' account sizes. Each storage
        /// summary is an array of key, value pairs, where each pair describes a storage
        /// bucket. The key indicates the upper bound of the bucket and the value is the number
        /// of users in that bucket. There is one such summary per day. If there is no data for
        /// a day, the storage summary will be empty.</para>
        /// </summary>
        public col.IList<col.IList<StorageBucket>> MemberStorageMap { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetStorageReport" />.</para>
        /// </summary>
        private class GetStorageReportEncoder : enc.StructEncoder<GetStorageReport>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetStorageReport value, enc.IJsonWriter writer)
            {
                WriteProperty("start_date", value.StartDate, writer, enc.StringEncoder.Instance);
                WriteListProperty("total_usage", value.TotalUsage, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_usage", value.SharedUsage, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("unshared_usage", value.UnsharedUsage, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("shared_folders", value.SharedFolders, writer, enc.UInt64Encoder.NullableInstance);
                WriteListProperty("member_storage_map", value.MemberStorageMap, writer, enc.Encoder.CreateListEncoder(Dropbox.Api.Team.StorageBucket.Encoder));
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetStorageReport" />.</para>
        /// </summary>
        private class GetStorageReportDecoder : enc.StructDecoder<GetStorageReport>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetStorageReport" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetStorageReport Create()
            {
                return new GetStorageReport();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetStorageReport value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "start_date":
                        value.StartDate = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "total_usage":
                        value.TotalUsage = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_usage":
                        value.SharedUsage = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "unshared_usage":
                        value.UnsharedUsage = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "shared_folders":
                        value.SharedFolders = ReadList<ulong?>(reader, enc.UInt64Decoder.NullableInstance);
                        break;
                    case "member_storage_map":
                        value.MemberStorageMap = ReadList<col.IList<StorageBucket>>(reader, enc.Decoder.CreateListDecoder(Dropbox.Api.Team.StorageBucket.Decoder));
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