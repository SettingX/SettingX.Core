﻿using SettingX.Core.Models;

namespace SettingX.Core.Entities
{
    public interface IKeyValueEntity
    {
        string KeyValueId { get; set; }
        string Value { get; set; }
        OverrideValue[] Override { get; set; }
        string[] Types { get; set; }
        bool? IsDuplicated { get; set; }
        bool? UseNotTaggedValue { get; set; }
        string[] RepositoryNames { get; set; }
        string RepositoryId { get; set; }
        string Tag { get; set; }
        string EmptyValueType { get; set; }
    }
}
