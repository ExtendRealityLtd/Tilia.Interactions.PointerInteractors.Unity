# Changelog

### [1.3.3](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.3.2...v1.3.3) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([218bb90](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/218bb9080ff5222f4795de09aa96a630fc2d0311))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.6 to 1.4.8. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.6...v1.4.8)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.3.1...v1.3.2) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([f59d4eb](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/f59d4eb80cb5f1036772d360745b2139b1ed1578))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.13.0 to 1.13.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.13.0...v1.13.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.3.0...v1.3.1) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.22.0 to 1.23.0 ([5a74d25](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/5a74d25b2cb0909ccdb698bcfa8eede2461b254e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.22.0 to 1.23.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.22.0...v1.23.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.2.0...v1.3.0) (2020-08-14)

#### Features

* **Prefabs:** add default rule to ignore special grab items ([dadfbbd](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/dadfbbdff8a1bc822db01f402633628b79369e2e))
  > The StringInList rule is now being used as a default rule applied to the DistanceGrabber so the distance grabber by default ignores any Interactable that has a String Observable List with the element `specialgrab` in the list.
  > 
  > This can be used to automatically ignore certain Interactables from being able to be position grabbed.

#### Bug Fixes

* **Configuration:** add check to see if action is of follow type ([f4a3f25](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/f4a3f25339e7517b880e87ca58a1e3f615bd593c))
  > There would be an error if the action was not of a follow type because the cast would automatically fail. This is fixed by not casting in the first instance and checking the type in the method.

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.13...v1.2.0) (2020-08-14)

#### Features

* **Prefabs:** support precision grab offset ([b410162](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/b4101628e179279818cc217193dd58bd5248a91a))
  > The Interactable precision grab offset is now supported when grabbing with the distance grabbing pointer by creating a temporary GameObject to use as the offset in the property applier.
  > 
  > The PropertyApplier also does not apply any rotation data now so the snap is positional only.

### [1.1.13](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.12...v1.1.13) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([ab50f49](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/ab50f4993a5ac493e47c9c7d010db9de9518f665))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.3 to 1.4.5. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.3...v1.4.5)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([b52e377](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/b52e377957f972edf6796bb132c13d31af20bbdd))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.12.0 to 1.12.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.12.0...v1.12.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.12](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.11...v1.1.12) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([06afd3f](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/06afd3f7967ee01b2a46d8508638937cd3ace144))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.11](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.10...v1.1.11) (2020-07-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([117d0a5](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/117d0a5156e097c35815d35970cf4c0fc5dfa2e3))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.11.1 to 1.12.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.11.1...v1.12.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.10](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.9...v1.1.10) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([28adecd](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/28adecdbfb53b423d471af034ae96bfa094d022d))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.2 to 1.4.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.2...v1.4.3)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.9](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.8...v1.1.9) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([de93a75](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/de93a75dbb733aff07436d7b0b564a9237415e22))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.0 to 1.4.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.0...v1.4.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.8](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.7...v1.1.8) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([6966dcb](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/6966dcb290c0dad4c9527b84b069cc234427bf8d))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.11.0 to 1.11.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.11.0...v1.11.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.7](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.6...v1.1.7) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([1707647](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/170764778c30fcfba8bf45baa9e002317cdd65ef))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.5...v1.1.6) (2020-07-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([84a7297](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/84a729733dacb02e3c40b9fee08f4fd9d54cbec6))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.3.1 to 1.4.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.3.1...v1.4.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.4...v1.1.5) (2020-07-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([acd1b39](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/acd1b3955e7160d5a8f5b7e4cc8c1bf7d9e89229))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.10.1 to 1.11.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.10.1...v1.11.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.3...v1.1.4) (2020-07-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([fd11969](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/fd11969f19bd749defc7a16f7cff6c0fdda70e6c))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.10.0 to 1.10.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.10.0...v1.10.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.2...v1.1.3) (2020-07-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([689f522](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/689f5225a3f292acb500ac15c8989a6fa46c9a8e))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.3.0 to 1.3.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.3.0...v1.3.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.1...v1.1.2) (2020-07-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([d794216](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/d794216b6ac0027e09eb4ddbbdd643f03bcb2309))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.13 to 1.3.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.13...v1.3.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.1.0...v1.1.1) (2020-07-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([4254725](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/4254725def871b389f63b3b131fdf9f0ab5c6b30))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.9.0 to 1.10.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.9.0...v1.10.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.11...v1.1.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([23f92d2](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/23f92d2f27ad659f78d3e17333fdaa31aae1ab6c))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([04890bd](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/04890bd0c24b5ea35817bbcb42a21e0f97c83cfd))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.0.11](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.10...v1.0.11) (2020-07-02)

#### Bug Fixes

* **Prefabs:** specify correct component for rule ([7bfe259](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/7bfe259ce1228fb2e87e66b2e382c49661353f59))
  > The InteractableFacade component had been deleted from the rule due to the change in namespace and Unity did not automatically update the component to the new script namespace. This has now been fixed.

### [1.0.10](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.9...v1.0.10) (2020-06-27)

#### Bug Fixes

* **Interactables:** update Interactables namespace to latest ([e9a2fb5](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/e9a2fb57a661380cf5c6d366da0f1771099b676f))
  > The Interactables namespace changed in version 1.9.0 of the Interactables package, so it has been updated accordingly.

### [1.0.9](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.8...v1.0.9) (2020-06-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([2b05aa5](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/2b05aa5757ef1e7d535feba81ed0b3f7a8b496ad))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.12 to 1.2.13. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.12...v1.2.13)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.8](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.7...v1.0.8) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([4c9d41c](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/4c9d41c4dd825268434a38ac8632a83edd775a23))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.8.0 to 1.8.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.8.0...v1.8.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.7](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.6...v1.0.7) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([b7bdfbb](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/b7bdfbb8746179f926a0c52e32f3afa380c68879))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.10 to 1.2.12. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.10...v1.2.12)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.6](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.5...v1.0.6) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([b260cf9](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/b260cf971f1756bfd0ef0c55962d672cd3eb8b5c))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.4...v1.0.5) (2020-06-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([bfef974](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/bfef974cadc70892083e7fccac0193406b11562f))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.9 to 1.2.10. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.9...v1.2.10)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.3...v1.0.4) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([6342339](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/63423394981d377e2a7f44c3ea6b98644b3a17cb))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.4 to 1.8.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.4...v1.8.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.2...v1.0.3) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([5b88259](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/5b882593d99d638f2e454dd364c115c0990cb0db))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.3 to 1.7.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.3...v1.7.4)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.1...v1.0.2) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([f3550e7](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/f3550e7859212ae14d87bac3f81f247208d9c445))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.7 to 1.2.9. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.7...v1.2.9)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/compare/v1.0.0...v1.0.1) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([0c0d105](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/0c0d1052c88a34e1b2a236deea743b4c93b8a41f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## 1.0.0 (2020-05-24)

#### Features

* **structure:** create initial prefab and user guides ([2579e99](https://github.com/ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity/commit/2579e99dec2069ea67627f4e3c189f33dad556d3))
  > The structure of the repository has been created with all the required files for the package, the prefab and the installation guide.
