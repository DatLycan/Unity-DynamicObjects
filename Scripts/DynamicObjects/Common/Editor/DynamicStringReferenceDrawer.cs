using UnityEditor;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<string>))]
    public class DynamicStringReferenceDrawer : DynamicReferenceDrawer { }
}