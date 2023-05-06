namespace Tilia.Interactions.PointerInteractors
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Cast;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Rule;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// The public interface into the PointerGrabber Prefab.
    /// </summary>
    public class PointerGrabberFacade : MonoBehaviour
    {
        #region Pointer Settings
        [Header("Pointer Settings")]
        [Tooltip("The source to get the internal pointer to follow.")]
        [SerializeField]
        private GameObject followSource;
        /// <summary>
        /// The source to get the internal pointer to follow.
        /// </summary>
        public GameObject FollowSource
        {
            get
            {
                return followSource;
            }
            set
            {
                followSource = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterFollowSourceChange();
                }
            }
        }
        [Tooltip("The Action to enable and disable the pointer with.")]
        [SerializeField]
        private BooleanAction activationAction;
        /// <summary>
        /// The Action to enable and disable the pointer with.
        /// </summary>
        public BooleanAction ActivationAction
        {
            get
            {
                return activationAction;
            }
            set
            {
                activationAction = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterActivationActionChange();
                }
            }
        }
        [Tooltip("The Action to attempt to get the pointer interactor to grab.")]
        [SerializeField]
        private BooleanAction grabAction;
        /// <summary>
        /// The Action to attempt to get the pointer interactor to grab.
        /// </summary>
        public BooleanAction GrabAction
        {
            get
            {
                return grabAction;
            }
            set
            {
                grabAction = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterGrabActionChange();
                }
            }
        }
        [Tooltip("The Action control the fixed pointer length.")]
        [SerializeField]
        private FloatAction lengthAxisAction;
        /// <summary>
        /// The Action control the fixed pointer length.
        /// </summary>
        public FloatAction LengthAxisAction
        {
            get
            {
                return lengthAxisAction;
            }
            set
            {
                lengthAxisAction = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterLengthAxisActionChange();
                }
            }
        }
        [Tooltip("The multiplier value of the given length axis input to increase or reduce the speed of the pointer length change.")]
        [SerializeField]
        private float lengthAxisMultiplier = 1f;
        /// <summary>
        /// The multiplier value of the given length axis input to increase or reduce the speed of the pointer length change.
        /// </summary>
        public float LengthAxisMultiplier
        {
            get
            {
                return lengthAxisMultiplier;
            }
            set
            {
                lengthAxisMultiplier = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterLengthAxisMultiplierChange();
                }
            }
        }
        [Tooltip("An optional VelocityTracker to use when applying velocity to the Interactor.\n\nIf one is not provided then a default VelocityTracker will be used that tracks the pointer cursor.")]
        [SerializeField]
        private VelocityTracker velocityTracker;
        /// <summary>
        /// An optional <see cref="VelocityTracker"/> to use when applying velocity to the Interactor.
        /// </summary>
        /// <remarks>
        /// If one is not provided then a default <see cref="VelocityTracker"/> will be used that tracks the pointer cursor.
        /// </remarks>
        public VelocityTracker VelocityTracker
        {
            get
            {
                return velocityTracker;
            }
            set
            {
                velocityTracker = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterVelocityTrackerChange();
                }
            }
        }
        [Tooltip("Whether to attempt to automatically grab upon the pointer entering a valid target.")]
        [SerializeField]
        private bool autoGrabOnEnter;
        /// <summary>
        /// Whether to attempt to automatically grab upon the pointer entering a valid target.
        /// </summary>
        public bool AutoGrabOnEnter
        {
            get
            {
                return autoGrabOnEnter;
            }
            set
            {
                autoGrabOnEnter = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterAutoGrabOnEnterChange();
                }
            }
        }
        #endregion

        #region Rule Settings
        [Header("Rule Settings")]
        [Tooltip("Determines which targets are valid to the pointer.")]
        [SerializeField]
        private RuleContainer targetValidity;
        /// <summary>
        /// Determines which targets are valid to the pointer.
        /// </summary>
        public RuleContainer TargetValidity
        {
            get
            {
                return targetValidity;
            }
            set
            {
                targetValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetValidityChange();
                }
            }
        }
        [Tooltip("Determines the rules for the pointer RayCast.")]
        [SerializeField]
        private PhysicsCast raycastRules;
        /// <summary>
        /// Determines the rules for the pointer RayCast.
        /// </summary>
        public PhysicsCast RaycastRules
        {
            get
            {
                return raycastRules;
            }
            set
            {
                raycastRules = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRaycastRulesChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private PointerGrabberConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public PointerGrabberConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Called after <see cref="FollowSource"/> has been changed.
        /// </summary>
        protected virtual void OnAfterFollowSourceChange()
        {
            Configuration.ConfigurePointer();
        }

        /// <summary>
        /// Called after <see cref="ActivationAction"/> has been changed.
        /// </summary>
        protected virtual void OnAfterActivationActionChange()
        {
            Configuration.ConfigurePointer();
        }

        /// <summary>
        /// Called after <see cref="GrabAction"/> has been changed.
        /// </summary>
        protected virtual void OnAfterGrabActionChange()
        {
            Configuration.ConfigureInteractor();
        }

        /// <summary>
        /// Called after <see cref="LengthAxisAction"/> has been changed.
        /// </summary>
        protected virtual void OnAfterLengthAxisActionChange()
        {
            Configuration.ConfigurePointer();
        }

        /// <summary>
        /// Called after <see cref="LengthAxisMultiplier"/> has been changed.
        /// </summary>
        protected virtual void OnAfterLengthAxisMultiplierChange()
        {
            Configuration.ConfigurePointer();
        }

        /// <summary>
        /// Called after <see cref="VelocityTracker"/> has been changed.
        /// </summary>
        protected virtual void OnAfterVelocityTrackerChange()
        {
            Configuration.ConfigureInteractor();
        }

        /// <summary>
        /// Called after <see cref="AutoGrabOnEnter"/> has been changed.
        /// </summary>
        protected virtual void OnAfterAutoGrabOnEnterChange()
        {
            Configuration.ConfigureGrabOnEnter();
        }

        /// <summary>
        /// Called after <see cref="TargetValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetValidityChange()
        {
            Configuration.ConfigurePointerRules();
        }

        /// <summary>
        /// Called after <see cref="RaycastRules"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRaycastRulesChange()
        {
            Configuration.ConfigurePointerRules();
        }
    }
}