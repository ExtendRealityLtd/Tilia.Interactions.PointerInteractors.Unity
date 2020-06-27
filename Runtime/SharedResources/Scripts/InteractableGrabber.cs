namespace Tilia.Interactions.PointerInteractors
{
    using Malimbe.BehaviourStateRequirementMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Interactions.Interactables.Interactables;
    using Tilia.Interactions.Interactables.Interactors;
    using UnityEngine;

    /// <summary>
    /// Attempts to grab the given interactable to the given interactor.
    /// </summary>
    public class InteractableGrabber : MonoBehaviour
    {
        /// <summary>
        /// The interactor to grab to.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public InteractorFacade Interactor { get; set; }
        /// <summary>
        /// The interactable to grab.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public InteractableFacade Interactable { get; set; }

        /// <summary>
        /// Attempts to grab the <see cref="Interactable"/> to the <see cref="Interactor"/>.
        /// </summary>
        [RequiresBehaviourState]
        public virtual void DoGrab()
        {
            if (Interactor == null || Interactable == null)
            {
                return;
            }

            Interactor.Grab(Interactable);
        }
    }
}