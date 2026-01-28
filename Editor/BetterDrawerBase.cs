using System;
using BetterAttributes.Runtime;
using UnityEditor;
using UnityEngine;

namespace BetterAttributes.Editor
{
    public class BetterDrawerBase<T> : PropertyDrawer where T : BetterAttributeBase
    {
        protected virtual SerializedPropertyType[] ValidTypes => new[] { SerializedPropertyType.ObjectReference };

        public bool ValidType(SerializedProperty property)
        {
            if (Array.Exists(ValidTypes, element => element == property.propertyType))
                return true;

            return false;
        }

        public void DisplayError(Rect position)
        {
            String validTypesString = string.Join(", ", ValidTypes);
            String message = $"{typeof(T).Name} can only be used with: {validTypesString}";
            GUIStyle style = new GUIStyle();
            style.normal.textColor = Color.red;
            GUI.Label(position, message, style);
            
            EditorGUI.EndProperty();
        }
    }
}
