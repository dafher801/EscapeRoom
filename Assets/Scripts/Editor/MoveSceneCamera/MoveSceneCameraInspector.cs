using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomEditor(typeof(MoveSceneCamera))]
public class MoveSceneCameraInspector : Editor
{
    public VisualTreeAsset m_InspectorXML;

    public override VisualElement CreateInspectorGUI()
    {
        // Create a new VisualElement to be the root of our inspector UI
        VisualElement myInspector = new VisualElement();

        // Load from default reference
        m_InspectorXML.CloneTree(myInspector);

        // Get a reference to the default inspector foldout control
        VisualElement inspectorFoldout = myInspector.Q("DefaultInspector");

        // Attach a default inspector to the foldout
        InspectorElement.FillDefaultInspector(inspectorFoldout, serializedObject, this);

        // Return the finished inspector UI
        return myInspector;
    }
}
