namespace Tilia.Interactions.PointerInteractors
{
    using System;
    using Tilia.Interactions.Interactables.Interactables;
    using Tilia.Interactions.Interactables.Interactors;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Cast;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface into the DistanceGrabber Prefab.
    /// </summary>
    public class DistanceGrabberFacade : MonoBehaviour
    {
        /// <summary>
        /// Defines the event with the <see cref="InteractableFacade"/>.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<InteractableFacade> { }

        #region Interaction Settings
        [Header("Interaction Settings")]
        [Tooltip("The InteractorFacade to grab to.")]
        [SerializeField]
        private InteractorFacade interactor;
        /// <summary>
        /// The <see cref="InteractorFacade"/> to grab to.
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
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterInteractorChange();
                }
            }
        }
        [Tooltip("An optional source to get the internal pointer to follow. If one isn't provided then the Interactor will be used.")]
        [SerializeField]
        private GameObject followSource;
        /// <summary>
        /// An optional source to get the internal pointer to follow. If one isn't provided then the <see cref="Interactor"/> will be used.
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
        [Tooltip("The time in which it will take the Interactable to transition to the Interactor.")]
        [SerializeField]
        private float transitionDuration;
        /// <summary>
        /// The time in which it will take the Interactable to transition to the Interactor.
        /// </summary>
        public float TransitionDuration
        {
            get
            {
                return transitionDuration;
            }
            set
            {
                transitionDuration = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTransitionDurationChange();
                }
            }
        }
        [Tooltip("The time in which to delay being able to distance grab again after ungrabbing.")]
        [SerializeField]
        private float ungrabDelay;
        /// <summary>
        /// The time in which to delay being able to distance grab again after ungrabbing.
        /// </summary>
        public float UngrabDelay
        {
            get
            {
                return ungrabDelay;
            }
            set
            {
                ungrabDelay = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterUngrabDelayChange();
                }
            }
        }
        #endregion

        #region Pointer Settings
        [Header("Pointer Settings")]
        [Tooltip("Determines which targets are valid to initiate the distance grab.")]
        [SerializeField]
        private RuleContainer targetValidity;
        /// <summary>
        /// Determines which targets are valid to initiate the distance grab.
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

        #region Grab Events
        /// <summary>
        /// Emitted before the grab occurs.
        /// </summary>
        [Header("Grab Events")]
        public UnityEvent BeforeGrabbed = new UnityEvent();
        /// <summary>
        /// Emitted if the grab occurrence is canceled.
        /// </summary>
        public UnityEvent GrabCanceled = new UnityEvent();
        /// <summary>
        /// Emitted after the grab occurs.
        /// </summary>
        public UnityEvent AfterGrabbed = new UnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private DistanceGrabberConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public DistanceGrabberConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// The current <see cref="InteractableFacade"/> being distance grabbed.
        /// </summary>
        public virtual InteractableFacade CurrentInteractable => Configuration.Grabber.Interactable;

        /// <summary>
        /// Clears <see cref="Interactor"/>.
        /// </summary>
        public virtual void ClearInteractor()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Interactor = default;
        }

        /// <summary>
        /// Clears <see cref="FollowSource"/>.
        /// </summary>
        public virtual void ClearFollowSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            FollowSource = default;
        }

        /// <summary>
        /// Clears <see cref="TargetValidity"/>.
        /// </summary>
        public virtual void ClearTargetValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            TargetValidity = default;
        }

        /// <summary>
        /// Clears <see cref="RaycastRules"/>.
        /// </summary>
        public virtual void ClearRaycastRules()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RaycastRules = default;
        }

        /// <summary>
        /// Called after <see cref="Interactor"/> has been changed.
        /// </summary>
        protected virtual void OnAfterInteractorChange()
        {
            Configuration.ConfigureInteractor();
        }

        /// <summary>
        /// Called after <see cref="FollowSource"/> has been changed.
        /// </summary>
        protected virtual void OnAfterFollowSourceChange()
        {
            Configuration.ConfigureInteractor();
        }

        /// <summary>
        /// Called after <see cref="TransitionDuration"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTransitionDurationChange()
        {
            Configuration.ConfigurePropertyApplier();
        }

        /// <summary>
        /// Called after <see cref="UngrabDelay"/> has been changed.
        /// </summary>
        protected virtual void OnAfterUngrabDelayChange()
        {
            Configuration.ConfigurePropertyApplier();
        }

        [Obsolete("Use `OnAfterUngrabDelayChange` instead.")]
        protected virtual void OnAfterConfigureReactivatePointerTimerChange()
        {
            OnAfterUngrabDelayChange();
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