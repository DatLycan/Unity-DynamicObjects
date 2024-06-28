using UnityEngine;

namespace DynamicObjects.Common {

    [CreateAssetMenu(
        fileName = "string",
        menuName = "Dynamic Objects/Variable/string",
        order = 3
    )]

    public class DynamicString : DynamicVariable<string> { }

}

