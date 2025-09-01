#if UNITY_EDITOR
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Ecs.Core.Utils.CodeGenerator.Editor
{
    public class CodeGenerator : EditorWindow
    {
        [MenuItem("Tools/Generate Component Extensions")]
        public static void GenerateExtensions()
        {
            var window = GetWindow<CodeGenerator>("Code Generator");
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.Label("Component Extension Generator", EditorStyles.boldLabel);
            
            if (GUILayout.Button("Generate All Extensions"))
            {
                GenerateAllExtensions();
            }
            
            GUILayout.Space(10);
            GUILayout.Label("This tool will generate extension methods for all components marked with [Generate] attribute.");
        }

        private void GenerateAllExtensions()
        {
            try
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                var componentTypes = assemblies
                    .SelectMany(assembly => assembly.GetTypes())
                    .Where(type => type.GetCustomAttribute<GenerateAttribute>() != null)
                    .ToList();

                if (componentTypes.Count == 0)
                {
                    Debug.LogWarning("No components found with [Generate] attribute.");
                    return;
                }

                var generatedPath = "Assets/Ecs/Generated/Components";
                if (!Directory.Exists(generatedPath))
                {
                    Directory.CreateDirectory(generatedPath);
                    AssetDatabase.Refresh();
                }

                int generatedCount = 0;
                foreach (var componentType in componentTypes)
                {
                    if (GenerateExtensionCode(componentType, generatedPath))
                    {
                        generatedCount++;
                    }
                }

                AssetDatabase.Refresh();
                Debug.Log($"Successfully generated {generatedCount} component extensions in {generatedPath}");
            }
            catch (Exception e)
            {
                Debug.LogError($"Error generating extensions: {e.Message}");
            }
        }

        private bool GenerateExtensionCode(Type componentType, string outputPath)
        {
            try
            {
                var componentName = componentType.Name;
                var fileName = $"{componentName}Extensions.cs";
                var filePath = Path.Combine(outputPath, fileName);

                var code = CreateExtensionFile(componentType, componentName);
                File.WriteAllText(filePath, code);

                return true;
            }
            catch (Exception e)
            {
                Debug.LogError($"Error generating extension for {componentType.Name}: {e.Message}");
                return false;
            }
        }

        private static string CreateExtensionFile(Type componentType, string componentName)
        {
            var template = $@"using Scellecs.Morpeh;
using {componentType.Namespace};

namespace Ecs.Generated.Components
{{
    public static class {componentName}Extensions
    {{
        public static Entity Add{componentName}(this Entity entity, {componentType.Name} component)
        {{
            World.Default.GetStash<{componentType.Name}>().Add(entity, component);
            return entity;
        }}
        
        public static Entity Set{componentName}(this Entity entity, {componentType.Name} component)
        {{
            World.Default.GetStash<{componentType.Name}>().Set(entity, component);
            return entity;
        }}
        
        public static Entity Remove{componentName}(this Entity entity)
        {{
            World.Default.GetStash<{componentType.Name}>().Remove(entity);
            return entity;
        }}
        
        public static bool Has{componentName}(this Entity entity)
        {{
            return World.Default.GetStash<{componentType.Name}>().Has(entity);
        }}
        
        public static {componentType.Name} Get{componentName}(this Entity entity)
        {{
            return World.Default.GetStash<{componentType.Name}>().Get(entity);
        }}
    }}
}}";
            
            return template;
        }
    }
}
#endif
