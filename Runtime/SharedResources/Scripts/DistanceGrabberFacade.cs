﻿namespace Tilia.Interactions.PointerInteractors
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Interactions.Interactables.Interactors;
    using UnityEngine;
    using Zinnia.Cast;
    using Zinnia.Data.Attribute;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface into the DistanceGrabber Prefab.
    /// </summary>
    public class DistanceGrabberFacade : MonoBehaviour
    {
        #region Interaction Settings
        /// <summary>
        /// The <see cref="InteractorFacade"/> to grab to.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Interaction Settings"), DocumentedByXml]
        public InteractorFacade Interactor { get; set; }
        /// <summary>
        /// The time in which it will take the interactable to transition to the interactor.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float TransitionDuration { get; set; }
        /// <summary>
        /// The time in which to delay being able to distance grab again after ungrabbing.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float UngrabDelay { get; set; }
        #endregion

        #region Pointer Settings
        /// <summary>
        /// Determines which targets are valid to initiate the distance grab.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Pointer Settings"), DocumentedByXml]
        public RuleContainer TargetValidity { get; set; }
        /// <summary>
        /// Determines the rules for the pointer raycast.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public PhysicsCast RaycastRules { get; set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public DistanceGrabberConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Called after <see cref="Interactor"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Interactor))]
        protected virtual void OnAfterInteractorChange()
        {
            Configuration.ConfigureInteractor();
        }

        /// <summary>
        /// Called after <see cref="TransitionDuration"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(TransitionDuration))]
        protected virtual void OnAfterTransitionDurationChange()
        {
            Configuration.ConfigurePropertyApplier();
        }

        /// <summary>
        /// Called after <see cref="UngrabDelay"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(UngrabDelay))]
        protected virtual void OnAfterConfigureReactivatePointerTimerChange()
        {
            Configuration.ConfigurePropertyApplier();
        }

        /// <summary>
        /// Called after <see cref="TargetValidity"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(TargetValidity))]
        protected virtual void OnAfterTargetValidityChange()
        {
            Configuration.ConfigurePointerRules();
        }

        /// <summary>
        /// Called after <see cref="RaycastRules"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(RaycastRules))]
        protected virtual void OnAfterRaycastRulesChange()
        {
            Configuration.ConfigurePointerRules();
        }
    }
}