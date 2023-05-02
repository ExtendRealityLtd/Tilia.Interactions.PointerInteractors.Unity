namespace Tilia.Interactions.PointerInteractors.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Interactions/Interactors/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.interactions.pointerinteractors.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabPointerInteractorsDistanceGrabber = "Interactions.PointerInteractors.DistanceGrabber";
        private const string prefabPointerInteractorsPointerGrabber = "Interactions.PointerInteractors.PointerGrabber";

        [MenuItem(menuItemRoot + prefabPointerInteractorsDistanceGrabber, false, priority)]
        private static void AddPointerInteractorsDistanceGrabber()
        {
            string prefab = prefabPointerInteractorsDistanceGrabber + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabPointerInteractorsPointerGrabber, false, priority)]
        private static void AddPointerInteractorsPointerGrabber()
        {
            string prefab = prefabPointerInteractorsPointerGrabber + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}