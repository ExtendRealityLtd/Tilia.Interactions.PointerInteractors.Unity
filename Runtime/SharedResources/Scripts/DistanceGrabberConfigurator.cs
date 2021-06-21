namespace Tilia.Interactions.PointerInteractors
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System.Collections;
    using System.Collections.Generic;
    using Tilia.Indicators.ObjectPointers;
    using Tilia.Interactions.Interactables.Interactables;
    using Tilia.Interactions.Interactables.Interactables.Grab.Action;
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

        #region Functionality Settings
        /// <summary>
        /// Determines whether the grab point will be created always or only if the <see cref="InteractableFacade"/> has a follow action that is set to <see cref="GrabInteractableFollowAction.OffsetType.PrecisionPoint"/>.
        /// </summary>
        [Serialized]
        [field: Header("Functionality Settings"), DocumentedByXml]
        public bool AlwaysCreateGrabPoint { get; set; }
        /// <summary>
        /// Forces the <see cref="InteractableFacade.InteractableRigidbody"/> to be kinematic during the transition.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool ForceKinematicOnTransition { get; set; } = true;
        /// <summary>
        /// Whether to disable the pointer logic when the <see cref="Facade.Interactor"/> touches the <see cref="InteractableFacade"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool DisablePointerOnInteractorTouch { get; set; } = true;
        #endregion

        #region Reference Settings
        /// <summary>
        /// The containing <see cref="GameObject"/> of the pointer logic.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public GameObject PointerContainer { get; protected set; }
        /// <summary>
        /// The <see cref="PointerFacade"/> to initiate the grabbing.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public PointerFacade Pointer { get; protected set; }
        /// <summary>
        /// The <see cref="InteractableGrabber"/> that initiates the grabbing.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public InteractableGrabber Grabber { get; protected set; }
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> that transitions the Interactable to the Interactor.
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
        /// The <see cref="BooleanAction"/> that proxies the Interactor's grab action.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public BooleanAction GrabProxy { get; protected set; }
        /// <summary>
        /// The <see cref="EmptyEventProxyEmitter"/> that is executed on the Interactor's grab action.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public EmptyEventProxyEmitter GrabProxyActions { get; protected set; }
        /// <summary>
        /// The <see cref="CountdownTimer"/> that controls when the pointer is reactivated.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public CountdownTimer ReactivatePointerTimer { get; protected set; }
        /// <summary>
        /// The container for the logic that enables the pointer.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject EnablePointerContainer { get; protected set; }
        /// <summary>
        /// The <see cref="RuleContainerObservableList"/> that controls pointer target validity.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public RuleContainerObservableList TargetValidityRules { get; protected set; }
        #endregion

        /// <summary>
        /// Whether to ignore the re-enabling of the pointer logic when the <see cref="Facade.Interactor"/> untouches.
        /// </summary>
        public bool ShouldIgnoreEnablePointer { get; set; }

        /// <summary>
        /// Whether the Interactor events have been subscribed to.
        /// </summary>
        protected bool hasSubscribedToInteractorEvents;
        /// <summary>
        /// The point at which to use as the grab point offset for the transition.
        /// </summary>
        protected GameObject grabPoint;
        /// <summary>
        /// The kinematic state of the <see cref="InteractableFacade.InteractableRigidbody"/> before the transition period.
        /// </summary>
        protected bool cachedKinematicState;
        /// <summary>
        /// The current grab precognition value for the associated Interactor.
        /// </summary>
        protected float cachedInteractorPrecognitionValue;

        /// <summary>
        /// A global static list of <see cref="DistanceGrabberConfigurator"/> for look up.
        /// </summary>
        public static List<DistanceGrabberConfigurator> ValidConfigurators = new List<DistanceGrabberConfigurator>();

        /// <summary>
        /// Configures the relevant components that require knowledge of the Interactor.
        /// </summary>
        public virtual void ConfigureInteractor()
        {
            Pointer.FollowSource = Facade.FollowSource != null ? Facade.FollowSource : Facade.Interactor.gameObject;
            Grabber.Interactor = Facade.Interactor;
            PropertyApplier.SetSource(Facade.Interactor.gameObject);
            GrabProxy.RunWhenActiveAndEnabled(() => GrabProxy.ClearSources());
            GrabProxy.RunWhenActiveAndEnabled(() => GrabProxy.AddSource(Facade.Interactor.GrabAction));

            UnregisterInteractorListeners();
            RegisterInteractorListeners();
        }

        /// <summary>
        /// Configures the property applier.
        /// </summary>
        public virtual void ConfigurePropertyApplier()
        {
            PropertyApplier.TransitionDuration = Facade.TransitionDuration.ApproxEquals(0f) ? 0.0001f : Facade.TransitionDuration;
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

        /// <summary>
        /// Creates the grab point offset to transition the target Interactable towards.
        /// </summary>
        /// <param name="hitData">The data to create the point with.</param>
        public virtual void CreateGrabPoint(RaycastHit hitData)
        {
            InteractableFacade interactable = hitData.transform.gameObject.TryGetComponent<InteractableFacade>(true, true);
            if (interactable == null)
            {
                return;
            }

            DestroyGrabPoint();

            if (AlwaysCreateGrabPoint ||
                CanCreateGrabPoint(interactable.Configuration.GrabConfiguration.PrimaryAction) ||
                CanCreateGrabPoint(interactable.Configuration.GrabConfiguration.SecondaryAction))
            {
                grabPoint = new GameObject($"[Zinnia][GrabPointContainer][{hitData.transform.name}]");
                grabPoint.transform.position = hitData.point;
                grabPoint.transform.SetParent(hitData.transform);
                PropertyApplier.Offset = grabPoint;
            }
        }

        /// <summary>
        /// Destroys any existing grab point.
        /// </summary>
        public virtual void DestroyGrabPoint()
        {
            PropertyApplier.Offset = null;
            Destroy(grabPoint);
        }

        /// <summary>
        /// Makes the <see cref="InteractableFacade.InteractableRigidbody"/> kinematic.
        /// </summary>
        public virtual void MakeInteractableKinematic()
        {
            if (Facade.CurrentInteractable == null || !ForceKinematicOnTransition)
            {
                return;
            }

            cachedKinematicState = Facade.CurrentInteractable.InteractableRigidbody.isKinematic;
            Facade.CurrentInteractable.InteractableRigidbody.isKinematic = true;
        }

        /// <summary>
        /// Restores the <see cref="InteractableFacade.InteractableRigidbody"/> kinematic state to the value of <see cref="cachedKinematicState"/>.
        /// </summary>
        public virtual void RestoreCachedInteractableKinematicState()
        {
            if (Facade == null || Facade.CurrentInteractable == null || !ForceKinematicOnTransition)
            {
                return;
            }

            Facade.CurrentInteractable.InteractableRigidbody.isKinematic = cachedKinematicState;
            cachedKinematicState = Facade.CurrentInteractable.InteractableRigidbody.isKinematic;
        }

        /// <summary>
        /// Emits the <see cref="Facade.BeforeGrabbed"/> event.
        /// </summary>
        /// <param name="interactable">The payload to emit with.</param>
        public virtual void NotifyBeforeGrabbed(InteractableFacade interactable)
        {
            if (interactable == null)
            {
                return;
            }

            cachedInteractorPrecognitionValue = Facade.Interactor.GrabPrecognition;
            Facade.Interactor.GrabPrecognition = 0f;
            foreach (DistanceGrabberConfigurator configurator in ValidConfigurators)
            {
                if (!configurator.Equals(this))
                {
                    configurator.GrabProxyActions.Receive();
                }
            }
            interactable.Ungrab();

            Facade.BeforeGrabbed?.Invoke(interactable);
        }

        /// <summary>
        /// Emits the <see cref="Facade.GrabCanceled"/> event.
        /// </summary>
        public virtual void NotifyGrabCanceled()
        {
            if (Grabber == null || Grabber.Interactable == null)
            {
                return;
            }

            RestoreInteractorPrecognitionValue();
            Facade.GrabCanceled?.Invoke(Grabber.Interactable);
        }

        /// <summary>
        /// Emits the <see cref="Facade.AfterGrabbed"/> event.
        /// </summary>
        /// <param name="interactable">The payload to emit with.</param>
        public virtual void NotifyAfterGrabbed(InteractableFacade interactable)
        {
            if (interactable == null)
            {
                return;
            }

            RestoreInteractorPrecognitionValue();
            Facade.AfterGrabbed?.Invoke(interactable);
        }

        protected virtual void OnEnable()
        {
            ConfigureInteractor();
            ConfigurePropertyApplier();
            ConfigureReactivatePointerTimer();
            ConfigurePointerRules();
            if (!ValidConfigurators.Contains(this))
            {
                ValidConfigurators.Add(this);
            }
        }

        protected virtual IEnumerator Start()
        {
            yield return new WaitForEndOfFrame();
            OnEnable();
        }

        protected virtual void OnDisable()
        {
            RestoreInteractorPrecognitionValue();
            RestoreCachedInteractableKinematicState();

            UnregisterInteractorListeners();
            ValidConfigurators.Remove(this);
        }

        /// <summary>
        /// Restores the cached Interactor precognition value.
        /// </summary>
        protected virtual void RestoreInteractorPrecognitionValue()
        {
            if (Facade == null || Facade.Interactor == null)
            {
                return;
            }

            Facade.Interactor.GrabPrecognition = cachedInteractorPrecognitionValue;
            cachedInteractorPrecognitionValue = Facade.Interactor.GrabPrecognition;
        }

        /// <summary>
        /// Determines whether the grab point can be created for the given action.
        /// </summary>
        /// <param name="action">The action to check whether a grab point can be created for.</param>
        /// <returns>Whether the grab point can be created.</returns>
        protected virtual bool CanCreateGrabPoint(GrabInteractableAction action)
        {
            if (action == null || action.GetType() != typeof(GrabInteractableFollowAction))
            {
                return false;
            }

            GrabInteractableFollowAction followAction = (GrabInteractableFollowAction)action;
            return followAction != null && followAction.GrabOffset == GrabInteractableFollowAction.OffsetType.PrecisionPoint;
        }

        /// <summary>
        /// Registers the Interactor listeners.
        /// </summary>
        protected virtual void RegisterInteractorListeners()
        {
            if (Facade.Interactor != null)
            {
                Facade.Interactor.Touched.AddListener(HasTouched);
                Facade.Interactor.Untouched.AddListener(HasUntouched);
                Facade.Interactor.Grabbed.AddListener(PerformGrab);
                Facade.Interactor.Ungrabbed.AddListener(PerformUngrab);
                hasSubscribedToInteractorEvents = true;
            }
        }

        /// <summary>
        /// Unregisters the Interactor listeners.
        /// </summary>
        protected virtual void UnregisterInteractorListeners()
        {
            if (hasSubscribedToInteractorEvents)
            {
                Facade.Interactor.Touched.RemoveListener(HasTouched);
                Facade.Interactor.Untouched.RemoveListener(HasUntouched);
                Facade.Interactor.Grabbed.RemoveListener(PerformGrab);
                Facade.Interactor.Ungrabbed.RemoveListener(PerformUngrab);
                hasSubscribedToInteractorEvents = false;
            }
        }

        /// <summary>
        /// Handles the <see cref="Facade.Interactor"/> touching state.
        /// </summary>
        /// <param name="interactable">The Interactable being touched.</param>
        protected virtual void HasTouched(InteractableFacade interactable)
        {
            if (!DisablePointerOnInteractorTouch)
            {
                return;
            }

            PointerContainer.SetActive(false);
            EnablePointerContainer.SetActive(false);
        }

        /// <summary>
        /// Handles the <see cref="Facade.Interactor"/> untouching state.
        /// </summary>
        /// <param name="interactable">The Interactable being touched.</param>
        protected virtual void HasUntouched(InteractableFacade interactable)
        {
            EnablePointerContainer.SetActive(true);
            if (!DisablePointerOnInteractorTouch || ShouldIgnoreEnablePointer)
            {
                return;
            }

            PointerContainer.SetActive(true);
        }

        /// <summary>
        /// Performs the grab logic.
        /// </summary>
        /// <param name="interactable">The Interactable being grabbed.</param>
        protected virtual void PerformGrab(InteractableFacade interactable)
        {
            ShouldIgnoreEnablePointer = true;
            GrabListener.Receive();
        }

        /// <summary>
        /// Performs the ungrab logic.
        /// </summary>
        /// <param name="interactable">The Interactable being grabbed.</param>
        protected virtual void PerformUngrab(InteractableFacade interactable)
        {
            UngrabListener.Receive();
        }
    }
}