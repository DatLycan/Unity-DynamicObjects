using UnityEngine;

namespace DynamicObjects.Common {

    [CreateAssetMenu(
        fileName = "bool",
        menuName = "Dynamic Objects/Variable/bool",
        order = 1
    )]

    public class DynamicBool : DynamicVariable<bool> { }

}

