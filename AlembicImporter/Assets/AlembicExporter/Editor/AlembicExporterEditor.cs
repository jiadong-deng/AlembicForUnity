using System;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AlembicExporter))]
public class AlembicExporterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var t = target as AlembicExporter;

        if (t.isRecording)
        {
            if (GUILayout.Button("End Capture"))
            {
                t.EndCapture();
            }
        }
        else
        {
            if (GUILayout.Button("Begin Capture"))
            {
                t.BeginCapture();
            }

            if (GUILayout.Button("One Shot"))
            {
                t.OneShot();
            }
        }
    }
}
