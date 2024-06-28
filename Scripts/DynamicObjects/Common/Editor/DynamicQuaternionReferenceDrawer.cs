using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {
    [CustomPropertyDrawer(typeof(DynamicReference<Quaternion>))]
    public class QuaternionIntReferenceDrawer : DynamicReferenceDrawer { }
}