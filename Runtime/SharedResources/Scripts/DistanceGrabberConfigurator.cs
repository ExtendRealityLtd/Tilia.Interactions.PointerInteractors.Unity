namespace Tilia.Interactions.PointerInteractors
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Indicators.ObjectPointers;
    using Tilia.Interactions.Interactables;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Event.Proxy;
    using Zinnia.Extension;
    using Zinnia.Rule.Collection;
    using Zinnia.Tracking.Modification;
    using Zinnia.Utility;

    /// <summary>
    /// Sets up the DistanceGrabber Prefab based on the provided user settings.
    /// </summary>
    public class DistanceGrabberConfigurator : MonoBehaviour
    {
        #region Facade Settings
        /// <summary>
        /// The public facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public DistanceGrabberFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The <see cref="PointerFacade"/> to initiate the grabbing.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public PointerFacade Pointer { get; protected set; }
        /// <summary>
        /// The <see cref="InteractableGrabber"/> that initiates the grabbing.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public InteractableGrabber Grabber { get; protected set; }
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> that transitions the interactable to the interactor.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformPropertyApplier PropertyApplier { get; protected set; }
        /// <summary>
        /// The <see cref="EmptyEventProxyEmitter"/> that runs the grab logic.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public EmptyEventProxyEmitter GrabListener { get; protected set; }
        /// <summary>
        /// The <see cref="EmptyEventProxyEmitter"/> that runs the ungrab logic.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public EmptyEventProxyEmitter UngrabListener { get; protected set; }
        /// <summary>
        /// The <see cref="BooleanAction"/> that proxies the interactor's grab action.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public BooleanAction GrabProxy { get; protected set; }
        /// <summary>
        /// The <see cref="CountdownTimer"/> that controls when the pointer is reactivated.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public CountdownTimer ReactivatePointerTimer { get; protected set; }
        /// <summary>
        /// The <see cref="RuleContainerObservableList"/> that controls pointer target validity.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public RuleContainerObservableList TargetValidityRules { get; protected set; }
        #endregion

        /// <summary>
        /// Whether the interactor events have been subscribed to.
        /// </summary>
        protected bool hasSubscribedToInteractorEvents;

        /// <summary>
        /// Configures the relevant components that require knowledge of the interactor.
        /// </summary>
        public virtual void ConfigureInteractor()
        {
            Pointer.FollowSource = Facade.Interactor.gameObject;
            Grabber.Interactor = Facade.Interactor;
            PropertyApplier.SetSource(Facade.Interactor.gameObject);
            GrabProxy.RunWhenActiveAndEnabled(() => GrabProxy.ClearSources());
            GrabProxy.RunWhenActiveAndEnabled(() => GrabProxy.AddSource(Facade.Interactor.GrabAction));

            UnregisterInteractorGrabListeners();
            RegisterInteractorGrabListeners();
        }

        /// <summary>
        /// Configures the property applier.
        /// </summary>
        public virtual void ConfigurePropertyApplier()
        {
            PropertyApplier.TransitionDuration = Facade.TransitionDuration;
        }

        /// <summary>
        /// Configures the reactivate pointer timer.
        /// </summary>
        public virtual void ConfigureReactivatePointerTimer()
        {
            ReactivatePointerTimer.StartTime = Facade.UngrabDelay;
        }

        /// <summary>
        /// Configures the rules on the pointer.
        /// </summary>
        public virtual void ConfigurePointerRules()
        {
            if (TargetValidityRules.NonSubscribableElements.Count > 1)
            {
                TargetValidityRules.RunWhenActiveAndEnabled(() => TargetValidityRules.RemoveAt(1));
            }

            if (Facade.TargetValidity.Interface != null)
            {
                TargetValidityRules.RunWhenActiveAndEnabled(() => TargetValidityRules.Add(Facade.TargetValidity));
            }

            Pointer.RaycastRules = Facade.RaycastRules;
        }

        protected virtual void OnEnable()
        {
            ConfigureInteractor();
            ConfigurePropertyApplier();
            ConfigureReactivatePointerTimer();
            ConfigurePointerRules();
        }

        protected virtual void OnDisable()
        {
            UnregisterInteractorGrabListeners();
        }

        /// <summary>
        /// Registers the Interactor Grab listeners.
        /// </summary>
        protected virtual void RegisterInteractorGrabListeners()
        {
            if (Facade.Interactor != null)
            {
                Facade.Interactor.Grabbed.AddListener(PerformGrab);
                Facade.Interactor.Ungrabbed.AddListener(PerformUngrab);
                hasSubscribedToInteractorEvents = true;
            }
        }

        /// <summary>
        /// Unregisters the Interactor Grab listeners.
        /// </summary>
        protected virtual void UnregisterInteractorGrabListeners()
        {
            if (hasSubscribedToInteractorEvents)
            {
                Facade.Interactor.Grabbed.RemoveListener(PerformGrab);
                Facade.Interactor.Ungrabbed.RemoveListener(PerformUngrab);
                hasSubscribedToInteractorEvents = false;
            }
        }

        /// <summary>
        /// Performs the grab logic.
        /// </summary>
        /// <param name="interactable">The interactable being grabbed.</param>
        protected virtual void PerformGrab(InteractableFacade interactable)
        {
            GrabListener.Receive();
        }

        /// <summary>
        /// Performs the ungrab logic.
        /// </summary>
        /// <param name="interactable">The interactable being grabbed.</param>
        protected virtual void PerformUngrab(InteractableFacade interactable)
        {
            UngrabListener.Receive();
        }
    }
}