using BetterAttributes.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;

namespace BetterAttributes.Editor
{
    [CustomPropertyDrawer(typeof(RequireAttribute))]
    public class RequireDrawer : BetterDrawerBase<RequireAttribute>
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
            
            Rect fieldPosition = new Rect(position.x, position.y - EditorGUIUtility.singleLineHeight, position.width, EditorGUIUtility.singleLineHeight);
            
            //RequireAttribute requireAttribute = (RequireAttribute)attribute;
            if (property.objectReferenceValue == null) GUI.backgroundColor = Color.red;
            EditorGUILayout.PropertyField(property);
            
            EditorGUI.EndProperty();
        }
    }
}