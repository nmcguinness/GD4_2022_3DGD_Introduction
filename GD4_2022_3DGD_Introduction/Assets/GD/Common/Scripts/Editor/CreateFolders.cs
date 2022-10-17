using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace GD
{
    /// <summary>
    /// Creates a consistent folder system under a user defined project name
    /// Access from "GD/Utils/Create Project Folders" in the main menu
    /// </summary>
    /// <see cref="https://unity.com/how-to/organizing-your-project"/>
    public class CreateFolders : EditorWindow
    {
        private static string projectName = "GD";

        [SerializeField]
        public static List<string> folders = new List<string>() { "Scenes", "Scripts", "Data", "Animation", "Audio", "Materials", "Meshes", "Prefabs", "Textures", "Sprites" };

        [MenuItem("Tools/GD/Utils/Create project folders...")]
        private static void ShowProjectPopup()
        {
            var window = GetWindow(typeof(CreateFolders));
            var title = new GUIContent();
            title.text = "Create Project Folders";
            window.titleContent = title;
        }

        private static void CreateAllFolders()
        {
            List<string> folders = new List<string>
        {
            "Animations",
            "Audio",
            "Data",
            "Editor",
            "Materials",
            "Meshes",
            "Prefabs",
            "Scripts",
            "Scenes",
            "Shaders",
            "Textures",
            "UI",
        };

            foreach (string folder in folders)
            {
                string fullPath = $"Assets/{projectName}/{folder}";

                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }
            }

            AssetDatabase.Refresh();
        }

        private void OnGUI()
        {
            projectName = EditorGUILayout.TextField("Project Name: ", projectName);
            Repaint();
            GUILayout.Space(10);
            if (GUILayout.Button("Create Folders"))
            {
                CreateAllFolders();
                Close();
            }
        }
    }
}