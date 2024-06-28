using UnityEngine;

namespace DynamicObjects.Common {

    [CreateAssetMenu(
        fileName = "Quaternion",
        menuName = "Dynamic Objects/Variable/Quaternion",
        order = 9
    )]

    public class DynamicQuaternion : DynamicVariable<Quaternion> { }

}

