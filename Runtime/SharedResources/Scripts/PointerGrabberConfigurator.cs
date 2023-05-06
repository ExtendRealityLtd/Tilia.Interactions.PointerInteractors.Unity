namespace Tilia.Interactions.PointerInteractors
{
    using Tilia.Indicators.ObjectPointers;
    using Tilia.Interactions.Interactables.Interactors;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Collection.List;
    using Zinnia.Extension;
    using Zinnia.Rule.Collection;
    using Zinnia.Tracking.Follow;
    using Zinnia.Tracking.Velocity;

    public class PointerGrabberConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public facade.")]
        [SerializeField]
        [Restricted]
        private PointerGrabberFacade facade;
        /// <summary>
        /// The public facade.
        /// </summary>
        public PointerGrabberFacade Facade
        {
            get
            {
                return facade;
            }
            set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The PointerFacade for the internal pointer.")]
        [SerializeField]
        [Restricted]
        private PointerFacade pointer;
        /// <summary>
        /// The <see cref="PointerFacade"/> for the internal pointer.
        /// </summary>
        public PointerFacade Pointer
        {
            get
            {
                return pointer;
            }
            set
            {
                pointer = value;
            }
        }
        [Tooltip("The InteractorFacade for the internal interactor.")]
        [SerializeField]
        [Restricted]
        private InteractorFacade interactor;
        /// <summary>
        /// The <see cref="InteractorFacade"/> for the internal interactor.
        /// </summary>
        public InteractorFacade Interactor
        {
            get
            {
                return interactor;
            }
            set
            {
                interactor = value;
            }
        }
        [Tooltip("The FloatAction to link to the Facade.LengthAxisAction.")]
        [SerializeField]
        [Restricted]
        private FloatAction lengthAxisProxy;
        /// <summary>
        /// The <see cref="FloatAction"/> to link to the <see cref="Facade.LengthAxisAction"/>.
        /// </summary>
        public FloatAction LengthAxisProxy
        {
            get
            {
                return lengthAxisProxy;
            }
            set
            {
                lengthAxisProxy = value;
            }
        }
        [Tooltip("The FloatObservableList that holds the length axis multiplier value.")]
        [SerializeField]
        [Restricted]
        private FloatObservableList lengthAxisMultiplierList;
        /// <summary>
        /// The <see cref="FloatObservableList"/> that holds the length axis multiplier value.
        /// </summary>
        public FloatObservableList LengthAxisMultiplierList
        {
            get
            {
                return lengthAxisMultiplierList;
            }
            set
            {
                lengthAxisMultiplierList = value;
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
            set
            {
                targetValidityRules = value;
            }
        }
        [Tooltip("The container for the grab on enter logic.")]
        [SerializeField]
        [Restricted]
        private GameObject grabOnEnterLogic;
        /// <summary>
        /// The container for the grab on enter logic.
        /// </summary>
        public GameObject GrabOnEnterLogic
        {
            get
            {
                return grabOnEnterLogic;
            }
            set
            {
                grabOnEnterLogic = value;
            }
        }
        [Tooltip("The ObjectFollower to make the Interactor follow the Facade.FollowSource.")]
        [SerializeField]
        [Restricted]
        private ObjectFollower interactorFollower;
        /// <summary>
        /// The <see cref="ObjectFollower"/> to make the Interactor follow the <see cref="Facade.FollowSource"/>.
        /// </summary>
        public ObjectFollower InteractorFollower
        {
            get
            {
                return interactorFollower;
            }
            set
            {
                interactorFollower = value;
            }
        }
        [Tooltip("The default VelocityTracker to use when applying velocity to the Interactor if no Facade.VelocityTracker is provided.")]
        [SerializeField]
        [Restricted]
        private VelocityTracker defaultVelocityTracker;
        /// <summary>
        /// The default <see cref="VelocityTracker"/> to use when applying velocity to the Interactor if no <see cref="Facade.VelocityTracker"/> is provided
        /// </summary>
        public VelocityTracker DefaultVelocityTracker
        {
            get
            {
                return defaultVelocityTracker;
            }
            set
            {
                defaultVelocityTracker = value;
            }
        }
        #endregion

        /// <summary>
        /// Configures the relevant settings for the internal Pointer.
        /// </summary>
        public virtual void ConfigurePointer()
        {
            Pointer.FollowSource = Facade.FollowSource;
            Pointer.ActivationAction = Facade.ActivationAction;
            LengthAxisProxy.RunWhenActiveAndEnabled(() => SetLengthAxisProxySource());
            LengthAxisMultiplierList.RunWhenActiveAndEnabled(() => LengthAxisMultiplierList.SetAt(Facade.LengthAxisMultiplier, 1));
            InteractorFollower.Sources.RunWhenActiveAndEnabled(() => SetObjectFollowerSource());
        }

        /// <summary>
        /// Configures the relevant settings for the internal Interactor.
        /// </summary>
        public virtual void ConfigureInteractor()
        {
            Interactor.GrabAction = Facade.GrabAction;
            Interactor.VelocityTracker = Facade.VelocityTracker != null ? Facade.VelocityTracker : DefaultVelocityTracker;
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
        /// Configures the state of the grab on enter logic container.
        /// </summary>
        public virtual void ConfigureGrabOnEnter()
        {
            GrabOnEnterLogic.SetActive(Facade.AutoGrabOnEnter);
        }

        protected virtual void OnEnable()
        {
            ConfigurePointer();
            ConfigureInteractor();
            ConfigurePointerRules();
            ConfigureGrabOnEnter();
        }

        /// <summary>
        /// Sets the source on the Length Axis Proxy.
        /// </summary>
        protected virtual void SetLengthAxisProxySource()
        {
            LengthAxisProxy.ClearSources();
            if (Facade.LengthAxisAction != null)
            {
                LengthAxisProxy.AddSource(Facade.LengthAxisAction);
            }
        }

        /// <summary>
        /// Sets the source of the object follower to the <see cref="Facade.FollowSource"/>.
        /// </summary>
        protected virtual void SetObjectFollowerSource()
        {
            InteractorFollower.Sources.Clear();
            if (Facade.FollowSource != null)
            {
                InteractorFollower.Sources.Add(Facade.FollowSource);
            }
        }
    }
}