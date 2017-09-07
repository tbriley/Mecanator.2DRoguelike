using UnityEditor;
using UnityEngine;

namespace AlphaECS.Unity.Editor
{
    public class Vector3EditorInput : SimpleEditorInput<Vector3>
    {
        protected override Vector3 CreateTypeUI(string label, Vector3 value)
        { return EditorGUILayout.Vector3Field(label, value); }
    }
}