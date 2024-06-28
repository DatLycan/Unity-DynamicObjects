using UnityEngine;

namespace DynamicObjects.Common {

    [CreateAssetMenu(
        fileName = "GameObjectRuntimeSet",
        menuName = "Dynamic Objects/Runtime Set/GameObject",
        order = 1
    )]

    public class DynamicGameObjectRuntimeSet : DynamicRuntimeSet<GameObject> { }

}

