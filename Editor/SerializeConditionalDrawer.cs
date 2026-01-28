using BetterAttributes.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;

namespace BetterAttributes.Editor
{
    [CustomPropertyDrawer(typeof(SerializeConditionalAttribute))]
    public class SerializeConditionalDrawer : BetterDrawerBase<SerializeConditionalAttribute>
    {
        protected override SerializedPropertyType[] ValidTypes => new[] { SerializedPropertyType.ObjectReference };
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            
            if (!ValidType(property))
            {
                DisplayError(position);
                return;
            }
            
            Rect fieldPosition = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
            
            SerializeConditionalAttribute serializeConditionalAttribute = (SerializeConditionalAttribute)attribute;
            if (serializeConditionalAttribute.Condition) EditorGUI.PropertyField(fieldPosition, property);
            
            EditorGUI.EndProperty();
        }
        
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float returnValue;
            
            SerializeConditionalAttribute serializeConditionalAttribute = (SerializeConditionalAttribute)attribute;
            returnValue = serializeConditionalAttribute.Condition ? EditorGUIUtility.singleLineHeight : 0;
            return returnValue;
        }
    }
}