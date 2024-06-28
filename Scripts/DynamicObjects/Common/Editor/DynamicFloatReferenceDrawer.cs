using UnityEditor;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<float>))]
    public class DynamicFloatReferenceDrawer : DynamicReferenceDrawer { }
}