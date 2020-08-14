# Class InteractableGrabber

Attempts to grab the given Interactable to the given Interactor.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [Grabbed]
* [Properties]
  * [Interactable]
  * [Interactor]
* [Methods]
  * [DoGrab()]

## Details

##### Inheritance

* System.Object
* InteractableGrabber

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class InteractableGrabber : MonoBehaviour
```

### Fields

#### Grabbed

Emitted when the Grab has occurred.

##### Declaration

```
public UnityEvent Grabbed
```

### Properties

#### Interactable

The Interactable to grab.

##### Declaration

```
public InteractableFacade Interactable { get; set; }
```

#### Interactor

The Interactor to grab to.

##### Declaration

```
public InteractorFacade Interactor { get; set; }
```

### Methods

#### DoGrab()

Attempts to grab the [Interactable] to the [Interactor].

##### Declaration

```
public virtual void DoGrab()
```

[Tilia.Interactions.PointerInteractors]: README.md
[Interactable]: InteractableGrabber.md#Interactable
[Interactor]: InteractableGrabber.md#Interactor
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Grabbed]: #Grabbed
[Properties]: #Properties
[Interactable]: #Interactable
[Interactor]: #Interactor
[Methods]: #Methods
[DoGrab()]: #DoGrab
