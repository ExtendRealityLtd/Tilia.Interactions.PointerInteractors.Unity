# Class PointerGrabberConfigurator

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [DefaultVelocityTracker]
  * [Facade]
  * [GrabOnEnterLogic]
  * [Interactor]
  * [InteractorFollower]
  * [LengthAxisMultiplierList]
  * [LengthAxisProxy]
  * [Pointer]
  * [TargetValidityRules]
* [Methods]
  * [ConfigureGrabOnEnter()]
  * [ConfigureInteractor()]
  * [ConfigurePointer()]
  * [ConfigurePointerRules()]
  * [OnEnable()]
  * [SetLengthAxisProxySource()]
  * [SetObjectFollowerSource()]

## Details

##### Inheritance

* System.Object
* PointerGrabberConfigurator

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class PointerGrabberConfigurator : MonoBehaviour
```

### Properties

#### DefaultVelocityTracker

The default VelocityTracker to use when applying velocity to the Interactor if no Facade.VelocityTracker is provided

##### Declaration

```
public VelocityTracker DefaultVelocityTracker { get; set; }
```

#### Facade

The public facade.

##### Declaration

```
public PointerGrabberFacade Facade { get; set; }
```

#### GrabOnEnterLogic

The container for the grab on enter logic.

##### Declaration

```
public GameObject GrabOnEnterLogic { get; set; }
```

#### Interactor

The InteractorFacade for the internal interactor.

##### Declaration

```
public InteractorFacade Interactor { get; set; }
```

#### InteractorFollower

The ObjectFollower to make the Interactor follow the Facade.FollowSource.

##### Declaration

```
public ObjectFollower InteractorFollower { get; set; }
```

#### LengthAxisMultiplierList

The FloatObservableList that holds the length axis multiplier value.

##### Declaration

```
public FloatObservableList LengthAxisMultiplierList { get; set; }
```

#### LengthAxisProxy

The FloatAction to link to the Facade.LengthAxisAction.

##### Declaration

```
public FloatAction LengthAxisProxy { get; set; }
```

#### Pointer

The PointerFacade for the internal pointer.

##### Declaration

```
public PointerFacade Pointer { get; set; }
```

#### TargetValidityRules

The RuleContainerObservableList that controls pointer target validity.

##### Declaration

```
public RuleContainerObservableList TargetValidityRules { get; set; }
```

### Methods

#### ConfigureGrabOnEnter()

Configures the state of the grab on enter logic container.

##### Declaration

```
public virtual void ConfigureGrabOnEnter()
```

#### ConfigureInteractor()

Configures the relevant settings for the internal Interactor.

##### Declaration

```
public virtual void ConfigureInteractor()
```

#### ConfigurePointer()

Configures the relevant settings for the internal Pointer.

##### Declaration

```
public virtual void ConfigurePointer()
```

#### ConfigurePointerRules()

Configures the rules on the pointer.

##### Declaration

```
public virtual void ConfigurePointerRules()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### SetLengthAxisProxySource()

Sets the source on the Length Axis Proxy.

##### Declaration

```
protected virtual void SetLengthAxisProxySource()
```

#### SetObjectFollowerSource()

Sets the source of the object follower to the Facade.FollowSource.

##### Declaration

```
protected virtual void SetObjectFollowerSource()
```

[Tilia.Interactions.PointerInteractors]: README.md
[PointerGrabberFacade]: PointerGrabberFacade.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[DefaultVelocityTracker]: #DefaultVelocityTracker
[Facade]: #Facade
[GrabOnEnterLogic]: #GrabOnEnterLogic
[Interactor]: #Interactor
[InteractorFollower]: #InteractorFollower
[LengthAxisMultiplierList]: #LengthAxisMultiplierList
[LengthAxisProxy]: #LengthAxisProxy
[Pointer]: #Pointer
[TargetValidityRules]: #TargetValidityRules
[Methods]: #Methods
[ConfigureGrabOnEnter()]: #ConfigureGrabOnEnter
[ConfigureInteractor()]: #ConfigureInteractor
[ConfigurePointer()]: #ConfigurePointer
[ConfigurePointerRules()]: #ConfigurePointerRules
[OnEnable()]: #OnEnable
[SetLengthAxisProxySource()]: #SetLengthAxisProxySource
[SetObjectFollowerSource()]: #SetObjectFollowerSource
