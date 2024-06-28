using UnityEditor;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<char>))]
    public class DynamicCharReferenceDrawer : DynamicReferenceDrawer { }
}