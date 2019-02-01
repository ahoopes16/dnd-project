﻿using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using dnd_project.Core.Data;
using System;

namespace dnd_project.Core.BusinessModels
{
    [Serializable]
    public class AttributesListModel
    {
        #region Instance Variables and Properties
        private const int DEF_VALUE = 10;

        public Dictionary<string, AttributeModel> Attributes { get; set; }
        #endregion

        #region Constructor(s)
        public AttributesListModel()
        {
            Attributes = new Dictionary<string, AttributeModel>();
            JsonAttributeData attributeData = JsonConvert.DeserializeObject<JsonAttributeData>(Properties.Resources.AttributeData);

            foreach (string attrName in attributeData.Attributes.Keys)
            {
                Attributes[attrName] = new AttributeModel(attrName, attributeData.Attributes[attrName].Description, DEF_VALUE);
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Clears value added from a RaceModel from the ability
        /// </summary>
        /// <param name="attribute">string The name of the value that will be reduced</param>
        /// <param name="value">int The value of the attribute that will be removed</param>
        public void Clear(string attribute, int value)
        {
            Attributes[attribute].Value -= value;
        }

        /// <summary>
        /// Adds a value to an attribute
        /// </summary>
        /// <param name="attribute"></param>
        public void AddValue(string attribute, int value)
        {
            Attributes[attribute].Value += value;
        }

        public void SetValue(string attribute, int value)
        {
            Attributes[attribute].Value = value;
        }
        /// <summary>
        /// Returns a dictionary of the attribute/mod value pairs
        /// </summary>
        /// <returns>attribute/mod value pairs</returns>
        public Dictionary<string, int> GetAttributeMods()
        {
            Dictionary<string, int> attributeMods = new Dictionary<string, int>();

            foreach (string attr in Attributes.Keys)
            {
                attributeMods[attr] = Attributes[attr].Modifier;
            }

            return attributeMods;
        }
        /// <summary>
        /// Returns a dictionary of attrribute/value pairs
        /// </summary>
        /// <returns>attrribute/value pairs</returns>
        public Dictionary<string, int> GetAttributeValues()
        {
            Dictionary<string, int> attributeValues = new Dictionary<string, int>();

            foreach(string attr in Attributes.Keys)
            {
                attributeValues[attr] = Attributes[attr].Value;
            }

            return attributeValues;
        }
        /// <summary>
        /// Overriden ToString method to print for debugging purposes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("\n-----ATTRIBUTES-----\n");
            foreach (string attr_name in Attributes.Keys)
            {
                output.Append(Attributes[attr_name].ToString());
            }

            return output.ToString();
        }
        #endregion
    }
}