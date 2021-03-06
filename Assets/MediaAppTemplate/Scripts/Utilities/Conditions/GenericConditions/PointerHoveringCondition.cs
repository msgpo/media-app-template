﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

namespace Daydream.MediaAppTemplate {

  /// Condition that determines if an object is currently being pointed at by the EventSystem.
  public class PointerHoveringCondition : BaseCondition, IPointerEnterHandler, IPointerExitHandler {
    [SerializeField]
    private string conditionIdentifier;
  
    private bool isHovering = false;

    public override string ConditionIdentifier {
      get {
        return conditionIdentifier;
      }
    }

    public override bool CheckCondition() {
      return isHovering;
    }

    public void OnPointerEnter(PointerEventData other) {
      isHovering = true;
    }

    public void OnPointerExit(PointerEventData other) {
      isHovering = false;
    }
  }
}
