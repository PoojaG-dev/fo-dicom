﻿// Copyright (c) 2012-2019 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using System.Collections.Generic;
using System.Linq;

namespace Dicom.Media
{
    public class DicomDirectoryRecord : DicomDataset
    {
        #region Properties

        public DicomDirectoryRecord LowerLevelDirectoryRecord { get; set; }

        public DicomDirectoryRecord NextDirectoryRecord { get; set; }

        public DicomDirectoryRecordCollection LowerLevelDirectoryRecordCollection
            => new DicomDirectoryRecordCollection(LowerLevelDirectoryRecord);

        public uint Offset { get; internal set; }

        public string DirectoryRecordType
            => GetSingleValue<string>(DicomTag.DirectoryRecordType);

        #endregion

        public DicomDirectoryRecord()
        {
        }

        public DicomDirectoryRecord(IEnumerable<DicomItem> items)
            : base(items)
        {
        }


        public override string ToString()
        {
            return $"Directory Record Type: {DirectoryRecordType}, Lower level items: {LowerLevelDirectoryRecordCollection.Count()}";
        }
    }
}
