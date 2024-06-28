using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<Vector2>))]
    public class DynamicVector2ReferenceDrawer : DynamicReferenceDrawer { }
}