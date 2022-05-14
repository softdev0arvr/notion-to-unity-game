﻿using System;
using Newtonsoft.Json.Linq;
using UnityEngine.Assertions;

// ReSharper disable once CheckNamespace
namespace NotionToUnity
{
    public class NotionProperty<T>
    {
        public T Value { get; set; }

        protected readonly string m_name;
        protected readonly string m_notionType;

        protected NotionProperty(JToken property, Type dbItemType)
        {
            m_name = property["name"] == null ? property.GetKey() : property["name"].Value<string>();
            m_notionType = property["type"].Value<string>();
            Assert.IsNotNull(m_notionType);
            Assert.IsNotNull(property[m_notionType]);
        }

    }
}
