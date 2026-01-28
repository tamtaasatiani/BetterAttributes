using BetterAttributes.Runtime;
using UnityEditor;
using UnityEngine;

namespace BetterAttributes.Editor
{
    [CustomPropertyDrawer(typeof(BetterIconAttribute))]
    public sealed class BetterIconAttributeDrawer : BetterDrawerBase<BetterIconAttribute>
    {
        protected override SerializedPropertyType[] ValidTypes => new[] { SerializedPropertyType.ObjectReference };
        private float _squareSide = EditorGUIUtility.singleLineHeight * 4;
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            if (!ValidType(property))
            {
                DisplayError(position);
                return;
            }
            
            Rect iconPosition = new Rect(EditorGUIUtility.currentViewWidth - _squareSide, position.y, _squareSide, _squareSide);
            property.objectReferenceValue = EditorGUI.ObjectField(iconPosition, property.objectReferenceValue, typeof(Sprite), false);
            
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return _squareSide + EditorGUIUtility.singleLineHeight;
        }
    }
}
