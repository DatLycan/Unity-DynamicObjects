using UnityEditor;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<bool>))]
    public class DynamicBoolReferenceDrawer : DynamicReferenceDrawer { }
}