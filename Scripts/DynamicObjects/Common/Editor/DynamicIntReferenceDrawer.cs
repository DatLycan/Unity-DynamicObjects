using UnityEditor;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<int>))]
    public class DynamicIntReferenceDrawer : DynamicReferenceDrawer { }
}