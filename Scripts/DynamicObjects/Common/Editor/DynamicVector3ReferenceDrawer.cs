using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<Vector3>))]
    public class DynamicVector3ReferenceDrawer : DynamicReferenceDrawer { }
}