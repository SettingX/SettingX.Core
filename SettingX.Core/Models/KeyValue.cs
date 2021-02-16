﻿using System;

namespace SettingX.Core.Models
{
    public class KeyValue
    {
        public string KeyValueId { get; set; }
        public string Value { get; set; }
        public OverrideValue[] Override { get; set; } = Array.Empty<OverrideValue>();
        public string[] Types { get; set; }
        public bool? IsDuplicated { get; set; }
        public bool? UseNotTaggedValue { get; set; }
        public string[] RepositoryNames { get; set; }
        public string RepositoryId { get; set; }
        public string Tag { get; set; }
        public string EmptyValueType { get; set; }
    }
}
