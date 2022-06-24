namespace Tilia.Interactions.PointerInteractors
{
    using System.Collections;
    using System.Collections.Generic;
    using Tilia.Indicators.ObjectPointers;
    using Tilia.Interactions.Interactables.Interactables;
    using Tilia.Interactions.Interactables.Interactables.Grab.Action;
    using Tilia.Interactions.Interactables.Interactors;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
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
        [Header("Facade Settings")]
        [Tooltip("The public facade.")]
        [SerializeField]
        [Restricted]
        private DistanceGrabberFacade facade;
        /// <summary>
        /// The public facade.
        /// </summary>
        public DistanceGrabberFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Functionality Settings
        [Header("Functionality Settings")]
        [Tooltip("Determines whether the grab point will be created always or only if the InteractableFacade has a follow action that is set to GrabInteractableFollowAction.OffsetType.PrecisionPoint.")]
        [SerializeField]
        private bool alwaysCreateGrabPoint;
        /// <summary>
        /// Determines whether the grab point will be created always or only if the <see cref="InteractableFacade"/> has a follow action that is set to <see cref="GrabInteractableFollowAction.OffsetType.PrecisionPoint"/>.
        /// </summary>
        public bool AlwaysCreateGrabPoint
        {
            get
            {
                return alwaysCreateGrabPoint;
            }
            set
            {
                alwaysCreateGrabPoint = value;
            }
        }
        [Tooltip("Forces the InteractableFacade.InteractableRigidbody to be kinematic during the transition.")]
        [SerializeField]
        private bool forceKinematicOnTransition = true;
        /// <summary>
        /// Forces the <see cref="InteractableFacade.InteractableRigidbody"/> to be kinematic during the transition.
        /// </summary>
        public bool ForceKinematicOnTransition
        {
            get
            {
                return forceKinematicOnTransition;
            }
            set
            {
                forceKinematicOnTransition = value;
            }
        }
        [Tooltip("Whether to disable the pointer logic when the Facade.Interactor touches the InteractableFacade.")]
        [SerializeField]
        private bool disablePointerOnInteractorTouch = true;
        /// <summary>
        /// Whether to disable the pointer logic when the <see cref="Facade.Interactor"/> touches the <see cref="InteractableFacade"/>.
        /// </summary>
        public bool DisablePointerOnInteractorTouch
        {
            get
            {
                return disablePointerOnInteractorTouch;
            }
            set
            {
                disablePointerOnInteractorTouch = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The containing GameObject of the pointer logic.")]
        [SerializeField]
        [Restricted]
        private GameObject pointerContainer;
        /// <summary>
        /// The containing <see cref="GameObject"/> of the pointer logic.
        /// </summary>
        public GameObject PointerContainer
        {
            get
            {
                return pointerContainer;
            }
            protected set
            {
                pointerContainer = value;
            }
        }
        [Tooltip("The PointerFacade to initiate the grabbing.")]
        [SerializeField]
        [Restricted]
        private PointerFacade pointer;
        /// <summary>
        /// The <see cref="PointerFacade"/> to initiate the grabbing.
        /// </summary>
        public PointerFacade Pointer
        {
            get
            {
                return pointer;
            }
            protected set
            {
                pointer = value;
            }
        }
        [Tooltip("The InteractableGrabber that initiates the grabbing.")]
        [SerializeField]
        [Restricted]
        private InteractableGrabber grabber;
        /// <summary>
        /// The <see cref="InteractableGrabber"/> that initiates the grabbing.
        /// </summary>
        public InteractableGrabber Grabber
        {
            get
            {
                return grabber;
            }
            protected set
            {
                grabber = value;
            }
        }
        [Tooltip("The TransformPropertyApplier that transitions the Interactable to the Interactor.")]
        [SerializeField]
        [Restricted]
        private TransformPropertyApplier propertyApplier;
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> that transitions the Interactable to the Interactor.
        /// </summary>
        public TransformPropertyApplier PropertyApplier
        {
            get
            {
                return propertyApplier;
            }
            protected set
            {
                propertyApplier = value;
            }
        }
        [Tooltip("The EmptyEventProxyEmitter that runs the grab logic.")]
        [SerializeField]
        [Restricted]
        private EmptyEventProxyEmitter grabListener;
        /// <summary>
        /// The <see cref="EmptyEventProxyEmitter"/> that runs the grab logic.
        /// </summary>
        public EmptyEventProxyEmitter GrabListener
        {
            get
            {
                return grabListener;
            }
            protected set
            {
                grabListener = value;
            }
        }
        [Tooltip("The EmptyEventProxyEmitter that runs the ungrab logic.")]
        [SerializeField]
        [Restricted]
        private EmptyEventProxyEmitter ungrabListener;
        /// <summary>
        /// The <see cref="EmptyEventProxyEmitter"/> that runs the ungrab logic.
        /// </summary>
        public EmptyEventProxyEmitter UngrabListener
        {
            get
            {
                return ungrabListener;
            }
            protected set
            {
                ungrabListener = value;
            }
        }
        [Tooltip("The BooleanAction that proxies the Interactor's grab action.")]
        [SerializeField]
        [Restricted]
        private BooleanAction grabProxy;
        /// <summary>
        /// The <see cref="BooleanAction"/> that proxies the Interactor's grab action.
        /// </summary>
        public BooleanAction GrabProxy
        {
            get
            {
                return grabProxy;
            }
            protected set
            {
                grabProxy = value;
            }
        }
        [Tooltip("The EmptyEventProxyEmitter that is executed on the Interactor's grab action.")]
        [SerializeField]
        [Restricted]
        private EmptyEventProxyEmitter grabProxyActions;
        /// <summary>
        /// The <see cref="EmptyEventProxyEmitter"/> that is executed on the Interactor's grab action.
        /// </summary>
        public EmptyEventProxyEmitter GrabProxyActions
        {
            get
            {
                return grabProxyActions;
            }
            protected set
            {
                grabProxyActions = value;
            }
        }
        [Tooltip("The CountdownTimer that controls when the pointer is reactivated.")]
        [SerializeField]
        [Restricted]
        private CountdownTimer reactivatePointerTimer;
        /// <summary>
        /// The <see cref="CountdownTimer"/> that controls when the pointer is reactivated.
        /// </summary>
        public CountdownTimer ReactivatePointerTimer
        {
            get
            {
                return reactivatePointerTimer;
            }
            protected set
            {
                reactivatePointerTimer = value;
            }
        }
        [Tooltip("The container for the logic that enables the pointer.")]
        [SerializeField]
        [Restricted]
        private GameObject enablePointerContainer;
        /// <summary>
        /// The container for the logic that enables the pointer.
        /// </summary>
        public GameObject EnablePointerContainer
        {
            get
            {
                return enablePointerContainer;
            }
            protected set
            {
                enablePointerContainer = value;
            }
        }
        [Tooltip("The logic that enables the pointer.")]
        [SerializeField]
        [Restricted]
        private EmptyEventProxyEmitter enablePointerLogic;
        /// <summary>
        /// The logic that enables the pointer.
        /// </summary>
        public EmptyEventProxyEmitter EnablePointerLogic
        {
            get
            {
                return enablePointerLogic;
            }
            protected set
            {
                enablePointerLogic = value;
            }
        }
        [Tooltip("The RuleContainerObservableList that controls pointer target validity.")]
        [SerializeField]
        [Restricted]
        private RuleContainerObservableList targetValidityRules;
        /// <summary>
        /// The <see cref="RuleContainerObservableList"/> that controls pointer target validity.
        /// </summary>
        public RuleContainerObservableList TargetValidityRules
        {
            get
            {
                return targetValidityRules;
            }
            protected set
            {
                targetValidityRules = value;
            }
        }
        [Tooltip("An InteractorFacade that is used to simulate touch events with the pointer.")]
        [SerializeField]
        [Restricted]
        private InteractorFacade simulatedInteractor;
        /// <summary>
        /// An <see cref="InteractorFacade"/> that is used to simulate touch events with the pointer.
        /// </summary>
        public InteractorFacade SimulatedInteractor
        {
            get
            {
                return simulatedInteractor;
            }
            protected set
            {
                simulatedInteractor = value;
            }
        }
        [Tooltip("The container for the simulate touch logic.")]
        [SerializeField]
        [Restricted]
        private GameObject simulateTouchContainer;
        /// <summary>
        /// The container for the simulate touch logic.
        /// </summary>
        public GameObject SimulateTouchContainer
        {
            get
            {
                return simulateTouchContainer;
            }
            protected set
            {
                simulateTouchContainer = value;
            }
        }
        [Tooltip("The container for the simulate grab logic.")]
        [SerializeField]
        [Restricted]
        private GameObject simulateGrabContainer;
        /// <summary>
        /// The container for the simulate grab logic.
        /// </summary>
        public GameObject SimulateGrabContainer
        {
            get
            {
                return simulateGrabContainer;
            }
            protected set
            {
                simulateGrabContainer = value;
            }
        }
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
        /// A coroutine for managing the if interactable is active check.
        /// </summary>
        protected Coroutine checkInteractableActiveRoutine;

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

        /// <summary>
        /// Simulates a touch on the given Interactable.
        /// </summary>
        /// <param name="interactable">The Interactable to simulate the touch on.</param>
        public virtual void SimulateTouch(InteractableFacade interactable)
        {
            if (interactable == null || !interactable.TouchEnabled)
            {
                return;
            }

            interactable.Configuration.TouchConfiguration.NotifyTouch(SimulatedInteractor.gameObject);
        }

        /// <summary>
        /// Simulates an untouch on the given Interactable.
        /// </summary>
        /// <param name="interactable">The Interactable to simulate the untouch on.</param>
        public virtual void SimulateUntouch(InteractableFacade interactable)
        {
            if (interactable == null || !interactable.TouchEnabled)
            {
                return;
            }

            interactable.Configuration.TouchConfiguration.NotifyUntouch(SimulatedInteractor.gameObject);
        }

        public virtual void CheckGrabValidity(SurfaceData data)
        {
            if (data == null || data.CollisionData.transform == null)
            {
                return;
            }

            InteractableFacade interactable = data.CollisionData.transform.GetComponent<InteractableFacade>();

            if (interactable != null && !interactable.GrabEnabled)
            {
                SimulateGrabContainer.SetActive(false);
            }
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
            if (ShouldIgnoreEnablePointer)
            {
                if (interactable == null || !interactable.gameObject.activeInHierarchy)
                {
                    EnablePointerLogic.Receive();
                    ShouldIgnoreEnablePointer = false;
                }
                return;
            }

            if (!DisablePointerOnInteractorTouch)
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
            if (interactable != null && checkInteractableActiveRoutine == null)
            {
                checkInteractableActiveRoutine = StartCoroutine(CheckInteractableIsNotActiveAtEndOfFrame(interactable));
            }

            UngrabListener.Receive();
        }

        /// <summary>
        /// Cancels the if interactable is active coroutine check.
        /// </summary>
        protected virtual void CancelCheckInteractableActiveRoutine()
        {
            if (checkInteractableActiveRoutine != null)
            {
                StopCoroutine(checkInteractableActiveRoutine);
                checkInteractableActiveRoutine = null;
            }
        }

        /// <summary>
        /// Checks if the given interactable is not active after the end of the frame and peforms an ungrab if it is no longer active.
        /// </summary>
        /// <param name="interactable">The interactable to check.</param>
        /// <returns>An Enumerator to manage the running of the Coroutine.</returns>
        protected virtual IEnumerator CheckInteractableIsNotActiveAtEndOfFrame(InteractableFacade interactable)
        {
            if (interactable == null)
            {
                yield break;
            }

            yield return new WaitForEndOfFrame();
            if (!interactable.gameObject.activeInHierarchy)
            {
                EnablePointerContainer.SetActive(true);
                PerformUngrab(interactable);
            }

            checkInteractableActiveRoutine = null;
        }
    }
}