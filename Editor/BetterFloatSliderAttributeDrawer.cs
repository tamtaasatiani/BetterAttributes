using BetterAttributes.Runtime;
using UnityEditor;
using UnityEngine;

namespace BetterAttributes.Editor
{
    [CustomPropertyDrawer(typeof(BetterFloatSliderAttribute))]
    public sealed class BetterFloatSliderAttributeDrawer : BetterDrawerBase<BetterSliderAttribute>
    {
        protected override SerializedPropertyType[] ValidTypes => new[] { SerializedPropertyType.Float };
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            
            if (!ValidType(property))
            {
                DisplayError(position);
                return;
            }
            
            Rect sliderPosition = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
            
            BetterSliderAttribute betterSliderAttribute = (BetterSliderAttribute)attribute;
            property.floatValue = EditorGUI.Slider(sliderPosition, label, property.floatValue, betterSliderAttribute.Min, betterSliderAttribute.Max);
            
            EditorGUI.EndProperty();
        }
    }
}