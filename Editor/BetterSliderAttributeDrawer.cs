using UnityEditor;
using UnityEngine;

namespace BetterAttributes.Editor
{
    [CustomPropertyDrawer(typeof(BetterSliderAttribute))]
    public class BetterSliderAttributeDrawer : BetterDrawerBase<BetterSliderAttribute>
    {
        protected override SerializedPropertyType[] ValidTypes => new[] { SerializedPropertyType.Integer };
        
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
            property.intValue = EditorGUI.IntSlider(sliderPosition, label, property.intValue, betterSliderAttribute.Min, betterSliderAttribute.Max);
            
            EditorGUI.EndProperty();
        }
    }
}